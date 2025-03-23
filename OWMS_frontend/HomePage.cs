using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWMS_frontend
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async Task LoadData()
        {
            try
            {
                string apiUrl = "http://localhost:5000/api/product";

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<List<Product>>(responseBody);

                dataGridView1.Rows.Clear();
                foreach (var product in products)
                {
                    dataGridView1.Rows.Add(product.Name, product.Vendor, product.Barcode, product.Stock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤: {ex.Message}");
            }
        }
        private async void HomePage_Load(object sender, EventArgs e)
        {
            await LoadData();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            menuStrip3 = new MenuStrip();
            menuStrip4 = new MenuStrip();
            產品管理ToolStripMenuItem = new ToolStripMenuItem();
            廠商管理ToolStripMenuItem = new ToolStripMenuItem();
            庫存管理ToolStripMenuItem = new ToolStripMenuItem();
            審核管理ToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewButtonColumn();
            menuStrip4.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "海外倉系統";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 48);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1371, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = " 產品管理";
            // 
            // menuStrip2
            // 
            menuStrip2.AllowMerge = false;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 24);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1371, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1371, 24);
            menuStrip3.TabIndex = 3;
            menuStrip3.Text = "產品管理";
            // 
            // menuStrip4
            // 
            menuStrip4.ImageScalingSize = new Size(20, 20);
            menuStrip4.Items.AddRange(new ToolStripItem[] { 產品管理ToolStripMenuItem, 廠商管理ToolStripMenuItem, 庫存管理ToolStripMenuItem, 審核管理ToolStripMenuItem, 設定ToolStripMenuItem });
            menuStrip4.Location = new Point(0, 72);
            menuStrip4.Name = "menuStrip4";
            menuStrip4.Size = new Size(1371, 27);
            menuStrip4.TabIndex = 4;
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
            設定ToolStripMenuItem.Size = new Size(53, 23);
            設定ToolStripMenuItem.Text = "設定";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "搜尋框";
            // 
            // button1
            // 
            button1.Location = new Point(126, 117);
            button1.Name = "button1";
            button1.Size = new Size(53, 32);
            button1.TabIndex = 6;
            button1.Text = "搜尋";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductName, Supplier, Barcode, Stock, Actions });
            dataGridView1.Location = new Point(14, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 72);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "產品名稱";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // Supplier
            // 
            Supplier.HeaderText = "廠商";
            Supplier.MinimumWidth = 6;
            Supplier.Name = "Supplier";
            Supplier.Width = 125;
            // 
            // Barcode
            // 
            Barcode.HeaderText = "條碼";
            Barcode.MinimumWidth = 6;
            Barcode.Name = "Barcode";
            Barcode.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "庫存";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 125;
            // 
            // Actions
            // 
            Actions.HeaderText = "操作";
            Actions.Name = "Actions";
            Actions.Text = "編輯";
            Actions.UseColumnTextForButtonValue = true; 
            Actions.Width = 100;
            dataGridView1.Columns.Add(Actions);
            // 
            // HomePage
            // 
            ClientSize = new Size(1371, 632);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip4);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            Name = "HomePage";
            menuStrip4.ResumeLayout(false);
            menuStrip4.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 檢查是否點擊到「操作」欄位的按鈕
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Actions"].Index)
            {
                // 根據選中的按鈕執行操作
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    if (e.RowIndex % 2 == 0)  // 假設點擊的是編輯
                    {
                        MessageBox.Show($"編輯行: {selectedRow.Cells[0].Value.ToString()}");
                    }
                    else  // 假設點擊的是刪除
                    {
                        MessageBox.Show($"刪除行: {selectedRow.Cells[0].Value.ToString()}");
                    }
                }
            }
        }

        private Label label1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip3;
        private MenuStrip menuStrip4;
        private ToolStripMenuItem 產品管理ToolStripMenuItem;
        private ToolStripMenuItem 廠商管理ToolStripMenuItem;
        private ToolStripMenuItem 庫存管理ToolStripMenuItem;
        private ToolStripMenuItem 審核管理ToolStripMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewButtonColumn Actions;
        private MenuStrip menuStrip2;
    }
}
