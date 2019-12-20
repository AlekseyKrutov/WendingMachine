using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WendingMechine
{
    public partial class AddMoneyForm : Form
    {
        Form1 mainForm = null;
        public AddMoneyForm()
        {
            InitializeComponent();
        }
        public AddMoneyForm(Form1 form1) : this()
        {
            mainForm = form1;
        }
        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            double currentSum = mainForm.machine.PaymentBuffer.Sum();
            double money = 0;
            if (btn50Cents.Checked)
                money = 0.50;
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control is RadioButton && ((RadioButton)control).Checked)
                    {
                        money = double.Parse(((RadioButton)control).Text.Split(' ').FirstOrDefault());
                        break;
                    }
                }
            }
            if (mainForm.machine.CashSum < currentSum + money)
            {
                MessageBox.Show("Внесено слишком большое количество денег. Выдача сдачи не может быть произведена!");
                this.Close();
                return;
            }
            mainForm.machine.AddMoney(money);
            mainForm.balance.Text = mainForm.machine.PaymentBuffer.Sum().ToString();
            this.Close();
        }
    }
}
