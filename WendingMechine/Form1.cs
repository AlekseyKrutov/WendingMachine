using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using TradeFirmLib;

namespace WendingMechine
{
    public partial class Form1 : Form
    {
        int interval = 5000;
        Timer timerBuy = new Timer();
        Timer timerCancelBuy = new Timer();
        MachineProduct mp = new MachineProduct();
        public Machine machine = new Machine();
        public Form1()
        {
            InitializeComponent();
            timerBuy.Tick += TimerBuy_Tick;
            timerCancelBuy.Tick += TimerCancelBuy_Tick;
            timerBuy.Interval = interval;
            timerCancelBuy.Interval = interval;
            UserContext uc = new UserContext();
            machine = uc.Machines.Find(3);
            MachineYard mYard = uc.MachineYards
                .Include(m => m.ProdYard.Select(p => p.Product))
                .Include(p => p.ProdYard.Select(pr => pr.Product.ProductType))
                .Include(p => p.ProdYard.Select(pr => pr.Supply).Select(s => s.Products))
                .Include(m => m.Machine).Single(y => y.Machine.Id == machine.Id);
            List<ProductYard> products = mYard.ProdYard.Select(p => p).ToList();
            machine.FillProducts(products);
            FillDataGrid(machine.Columns, machine.Products);
            this.Text = machine.Firm + " " + machine.Model;
            mainDataGrid.Height = mainDataGrid.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 12;
            string ProductName = mainDataGrid.Rows[0].Cells[0].Value.ToString().Split('\n').First();
            balance.Text = double.Parse(machine.PaymentBuffer.Sum().ToString()).ToString();
        }

        public Form1(AddMoneyForm addMoneyForm)
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mainDataGrid.ClearSelection();
        }
        private void FillDataGrid(int columns, List<MachineProduct> products)
        {
            int rows = (int) Math.Ceiling((double)products.Count / columns);
            mainDataGrid.RowCount = rows;
            mainDataGrid.ColumnCount = columns;
            int m = 0;
            for (int i = 0; i < Math.Ceiling((double)products.Count / columns); i++)
            {
                for (int j = 0; j < columns; j++, m++)
                {
                    if (m < products.Count)
                        mainDataGrid.Rows[i].Cells[j].Value = products[m].NameProd + "\n"
                            + "---------------" + "\n" + products[m].Cost + "р.";
                    else i = rows;
                }
            }
        }

        private void mainDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object cellvalue = mainDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (cellvalue == null)
                mainDataGrid.ClearSelection();
        }

        private void addMoneyBtn_Click(object sender, EventArgs e)
        {
            AddMoneyForm addMoneyForm = new AddMoneyForm(this);
            addMoneyForm.ShowDialog();
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (mainDataGrid.SelectedCells.Count == 0 || machine.PaymentBuffer.Sum() == 0)
            {
                MessageBox.Show("Для покупки необходимо выбрать товар и внести деньги!");
                return;
            }
            mp = machine.Products[mainDataGrid.CurrentRow.Index * mainDataGrid.CurrentCell.ColumnIndex];
            if ((double)mp.Cost > machine.PaymentBuffer.Sum())
            {
                MessageBox.Show("Внесенная сумма меньше стоимости товара!");
                return;
            }
            timerBuy.Interval = interval;
            timerBuy.Enabled = true;
            stateLabel.Text = "Производится\nпокупка...";
            DisableBtns(new Button[] { buyBtn, addMoneyBtn });
        }

        private void TimerBuy_Tick(object sender, EventArgs e)
        {
            timerBuy.Enabled = false;
            BuyProduct();
            ResetAll();
        }
        private void TimerCancelBuy_Tick(object sender, EventArgs e)
        {
            timerCancelBuy.Enabled = false;
            ResetAll();
            EnableBtns(new Button[] { buyBtn, cancelBuyingBtn, addMoneyBtn });
            MessageBox.Show("Покупка отменена!");
        }
        private void cancelBuyingBtn_Click(object sender, EventArgs e)
        {
            if (timerBuy.Enabled)
            {
                timerBuy.Enabled = false;
                stateLabel.Text = "Отмена покупки...";
                timerCancelBuy.Enabled = true;
                DisableBtns(new Button[] { buyBtn, cancelBuyingBtn, addMoneyBtn });
            }
            else if (!timerCancelBuy.Enabled)
                ResetAll();
        }
        private void BuyProduct()
        {
            int row = mainDataGrid.CurrentRow.Index;
            int col = mainDataGrid.CurrentCell.ColumnIndex;
            int index = ((row + 1) * mainDataGrid.Columns.Count) - (mainDataGrid.Columns.Count - (col + 1));
            index -= 1;
            deliveryBox.Text = mp.NameProd;
            machine.BuyProduct(index);
            mainDataGrid.Rows[row].Cells[col].Value = null;
            mainDataGrid.Rows.Clear();
            FillDataGrid(machine.Columns, machine.Products);
            mainDataGrid.ClearSelection();
            MessageBox.Show("Покупка завершена. Заберите товар из лотка!");
            EnableBtns(new Button[] { buyBtn, cancelBuyingBtn, addMoneyBtn });
            ResetAll();
        }
        private void ResetAll()
        {
            mainDataGrid.ClearSelection();
            machine.PaymentBuffer.Clear();
            balance.Text = machine.PaymentBuffer.Sum().ToString();
            stateLabel.Text = "";
            deliveryBox.Text = "";
        }
        private void EnableBtns(Button[] buttons)
        {
            foreach (Button b in buttons)
                b.Enabled = true;
        }
        private void DisableBtns(Button[] buttons)
        {
            foreach (Button b in buttons)
                b.Enabled = false;
        }
    }
}
