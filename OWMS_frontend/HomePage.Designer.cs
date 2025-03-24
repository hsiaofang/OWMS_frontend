
namespace OWMS_frontend
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog1 = new ColorDialog();
            menuStrip4 = new MenuStrip();
            產品管理ToolStripMenuItem = new ToolStripMenuItem();
            廠商管理ToolStripMenuItem = new ToolStripMenuItem();
            庫存管理ToolStripMenuItem = new ToolStripMenuItem();
            審核管理ToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            海外倉系統ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            OrderNumber = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Vendor = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewButtonColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            menuStrip4.SuspendLayout();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip4
            // 
            menuStrip4.ImageScalingSize = new Size(20, 20);
            menuStrip4.Items.AddRange(new ToolStripItem[] { 產品管理ToolStripMenuItem, 廠商管理ToolStripMenuItem, 庫存管理ToolStripMenuItem, 審核管理ToolStripMenuItem, 設定ToolStripMenuItem, 設定ToolStripMenuItem1 });
            menuStrip4.Location = new Point(0, 75);
            menuStrip4.Name = "menuStrip4";
            menuStrip4.Size = new Size(1092, 27);
            menuStrip4.TabIndex = 8;
            menuStrip4.Text = "產品管理";
            // 
            // 產品管理ToolStripMenuItem
            // 
            產品管理ToolStripMenuItem.Name = "產品管理ToolStripMenuItem";
            產品管理ToolStripMenuItem.Size = new Size(83, 23);
            產品管理ToolStripMenuItem.Text = "產品管理";
            // 
            // 廠商管理ToolStripMenuItem
            // 
            廠商管理ToolStripMenuItem.Name = "廠商管理ToolStripMenuItem";
            廠商管理ToolStripMenuItem.Size = new Size(83, 23);
            廠商管理ToolStripMenuItem.Text = "廠商管理";
            // 
            // 庫存管理ToolStripMenuItem
            // 
            庫存管理ToolStripMenuItem.Name = "庫存管理ToolStripMenuItem";
            庫存管理ToolStripMenuItem.Size = new Size(83, 23);
            庫存管理ToolStripMenuItem.Text = "庫存管理";
            // 
            // 審核管理ToolStripMenuItem
            // 
            審核管理ToolStripMenuItem.Name = "審核管理ToolStripMenuItem";
            審核管理ToolStripMenuItem.Size = new Size(83, 23);
            審核管理ToolStripMenuItem.Text = "審核管理";
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(83, 23);
            設定ToolStripMenuItem.Text = "人員管理";
            // 
            // 設定ToolStripMenuItem1
            // 
            設定ToolStripMenuItem1.Name = "設定ToolStripMenuItem1";
            設定ToolStripMenuItem1.Size = new Size(53, 23);
            設定ToolStripMenuItem1.Text = "設定";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 51);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1092, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = " 產品管理";
            // 
            // menuStrip2
            // 
            menuStrip2.AllowMerge = false;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { 海外倉系統ToolStripMenuItem });
            menuStrip2.Location = new Point(0, 24);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1092, 27);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // 海外倉系統ToolStripMenuItem
            // 
            海外倉系統ToolStripMenuItem.Name = "海外倉系統ToolStripMenuItem";
            海外倉系統ToolStripMenuItem.Size = new Size(98, 23);
            海外倉系統ToolStripMenuItem.Text = "海外倉系統";
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1092, 24);
            menuStrip3.TabIndex = 7;
            menuStrip3.Text = "產品管理";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 27);
            textBox2.TabIndex = 13;
            textBox2.Text = "訂單編號";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderNumber, Supplier, Date, Vendor, OrderDate, Actions });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(884, 169);
            dataGridView1.TabIndex = 12;
            // 
            // OrderNumber
            // 
            OrderNumber.HeaderText = "訂單編號";
            OrderNumber.MinimumWidth = 6;
            OrderNumber.Name = "OrderNumber";
            OrderNumber.Width = 125;
            // 
            // Supplier
            // 
            Supplier.HeaderText = "區間單號";
            Supplier.MinimumWidth = 6;
            Supplier.Name = "Supplier";
            Supplier.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "入倉日期";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Vendor
            // 
            Vendor.HeaderText = "廠商";
            Vendor.MinimumWidth = 6;
            Vendor.Name = "Vendor";
            Vendor.Width = 125;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "訂單日期";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 125;
            // 
            // Actions
            // 
            Actions.HeaderText = "操作";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            Actions.Text = "";
            Actions.UseColumnTextForButtonValue = true;
            Actions.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(282, 121);
            button1.Name = "button1";
            button1.Size = new Size(53, 32);
            button1.TabIndex = 11;
            button1.Text = "搜尋";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click_3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 27);
            textBox1.TabIndex = 10;
            textBox1.Text = "區間單號";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 579);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip4);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            Name = "HomePage";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip4.ResumeLayout(false);
            menuStrip4.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ColorDialog colorDialog1;
        private MenuStrip menuStrip4;
        private ToolStripMenuItem 產品管理ToolStripMenuItem;
        private ToolStripMenuItem 廠商管理ToolStripMenuItem;
        private ToolStripMenuItem 庫存管理ToolStripMenuItem;
        private ToolStripMenuItem 審核管理ToolStripMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem 海外倉系統ToolStripMenuItem;
        private MenuStrip menuStrip3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OrderNumber;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Vendor;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewButtonColumn Actions;
        private Button button1;
        private TextBox textBox1;
    }
}