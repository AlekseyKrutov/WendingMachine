namespace WendingMechine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.deliveryBox = new System.Windows.Forms.TextBox();
            this.addMoneyBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.balanceTitleLabel = new System.Windows.Forms.Label();
            this.cancelBuyingBtn = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.AllowUserToAddRows = false;
            this.mainDataGrid.AllowUserToDeleteRows = false;
            this.mainDataGrid.AllowUserToResizeColumns = false;
            this.mainDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.ColumnHeadersVisible = false;
            this.mainDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainDataGrid.Location = new System.Drawing.Point(6, 63);
            this.mainDataGrid.MultiSelect = false;
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainDataGrid.RowHeadersVisible = false;
            this.mainDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mainDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.mainDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDataGrid.RowTemplate.Height = 50;
            this.mainDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mainDataGrid.Size = new System.Drawing.Size(503, 361);
            this.mainDataGrid.TabIndex = 0;
            this.mainDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGrid_CellClick);
            // 
            // deliveryBox
            // 
            this.deliveryBox.Enabled = false;
            this.deliveryBox.Location = new System.Drawing.Point(6, 437);
            this.deliveryBox.Multiline = true;
            this.deliveryBox.Name = "deliveryBox";
            this.deliveryBox.Size = new System.Drawing.Size(111, 105);
            this.deliveryBox.TabIndex = 1;
            // 
            // addMoneyBtn
            // 
            this.addMoneyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMoneyBtn.Location = new System.Drawing.Point(385, 437);
            this.addMoneyBtn.Name = "addMoneyBtn";
            this.addMoneyBtn.Size = new System.Drawing.Size(118, 40);
            this.addMoneyBtn.TabIndex = 2;
            this.addMoneyBtn.Text = "Внести деньги";
            this.addMoneyBtn.UseVisualStyleBackColor = true;
            this.addMoneyBtn.Click += new System.EventHandler(this.addMoneyBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyBtn.Location = new System.Drawing.Point(385, 483);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(118, 40);
            this.buyBtn.TabIndex = 3;
            this.buyBtn.Text = "Купить";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(9, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(134, 20);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Выберите товар";
            // 
            // balanceTitleLabel
            // 
            this.balanceTitleLabel.AutoSize = true;
            this.balanceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceTitleLabel.Location = new System.Drawing.Point(176, 453);
            this.balanceTitleLabel.Name = "balanceTitleLabel";
            this.balanceTitleLabel.Size = new System.Drawing.Size(79, 24);
            this.balanceTitleLabel.TabIndex = 5;
            this.balanceTitleLabel.Text = "Баланс:";
            // 
            // cancelBuyingBtn
            // 
            this.cancelBuyingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBuyingBtn.Location = new System.Drawing.Point(385, 529);
            this.cancelBuyingBtn.Name = "cancelBuyingBtn";
            this.cancelBuyingBtn.Size = new System.Drawing.Size(118, 40);
            this.cancelBuyingBtn.TabIndex = 6;
            this.cancelBuyingBtn.Text = "Отменить покупку";
            this.cancelBuyingBtn.UseVisualStyleBackColor = true;
            this.cancelBuyingBtn.Click += new System.EventHandler(this.cancelBuyingBtn_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance.Location = new System.Drawing.Point(261, 453);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(20, 24);
            this.balance.TabIndex = 7;
            this.balance.Text = "$";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.Location = new System.Drawing.Point(176, 489);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(0, 24);
            this.stateLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 576);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.cancelBuyingBtn);
            this.Controls.Add(this.balanceTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.addMoneyBtn);
            this.Controls.Add(this.deliveryBox);
            this.Controls.Add(this.mainDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.TextBox deliveryBox;
        private System.Windows.Forms.Button addMoneyBtn;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label balanceTitleLabel;
        private System.Windows.Forms.Button cancelBuyingBtn;
        public System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label stateLabel;
    }
}

