
namespace OWMS_frontend
{
    partial class ProductMangagement
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
            btnAddVendor = new Button();
            dataGridView1 = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Image = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            Vendor = new DataGridViewTextBoxColumn();
            Counter = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            btnSearchVendor = new Button();
            searchProductBox = new TextBox();
            vendorDropdown = new ComboBox();
            counterDropdown = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddVendor
            // 
            btnAddVendor.Location = new Point(91, 89);
            btnAddVendor.Name = "btnAddVendor";
            btnAddVendor.Size = new Size(122, 28);
            btnAddVendor.TabIndex = 9;
            btnAddVendor.Text = "+ 新增產品\t";
            btnAddVendor.UseVisualStyleBackColor = true;
            btnAddVendor.Click += btnAddVendor_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductName, Price, Image, Code, Vendor, Counter, Action });
            dataGridView1.Location = new Point(81, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1268, 415);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "產品名稱";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "價格";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Image
            // 
            Image.HeaderText = "圖片";
            Image.MinimumWidth = 6;
            Image.Name = "Image";
            Image.Width = 125;
            // 
            // Code
            // 
            Code.HeaderText = "QRCode";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            Code.Width = 125;
            // 
            // Vendor
            // 
            Vendor.HeaderText = "所屬廠商";
            Vendor.MinimumWidth = 6;
            Vendor.Name = "Vendor";
            Vendor.Width = 125;
            // 
            // Counter
            // 
            Counter.HeaderText = "所屬櫃號";
            Counter.MinimumWidth = 6;
            Counter.Name = "Counter";
            Counter.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "操作";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Width = 125;
            // 
            // btnSearchVendor
            // 
            btnSearchVendor.Location = new Point(1255, 88);
            btnSearchVendor.Name = "btnSearchVendor";
            btnSearchVendor.Size = new Size(94, 29);
            btnSearchVendor.TabIndex = 7;
            btnSearchVendor.Text = "🔍 搜尋";
            btnSearchVendor.UseVisualStyleBackColor = true;
            btnSearchVendor.Click += btnSearchVendor_Click;
            // 
            // searchProductBox
            // 
            searchProductBox.Location = new Point(531, 91);
            searchProductBox.Name = "searchProductBox";
            searchProductBox.Size = new Size(125, 27);
            searchProductBox.TabIndex = 6;
            searchProductBox.Text = "搜尋產品名稱：";
            searchProductBox.TextChanged += txtSearchVendor_TextChanged;
            // 
            // vendorDropdown
            // 
            vendorDropdown.FormattingEnabled = true;
            vendorDropdown.Location = new Point(784, 90);
            vendorDropdown.Name = "vendorDropdown";
            vendorDropdown.Size = new Size(140, 27);
            vendorDropdown.TabIndex = 11;
            vendorDropdown.Text = "全部";
            vendorDropdown.SelectedIndexChanged += VendorList_SelectedIndexChanged;
            // 
            // counterDropdown
            // 
            counterDropdown.FormattingEnabled = true;
            counterDropdown.Location = new Point(1054, 90);
            counterDropdown.Name = "counterDropdown";
            counterDropdown.Size = new Size(149, 27);
            counterDropdown.TabIndex = 12;
            counterDropdown.Text = "全部";
            counterDropdown.SelectedIndexChanged += CounterList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(694, 93);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 13;
            label1.Text = "廠商篩選：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(964, 93);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 14;
            label2.Text = "櫃號篩選：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 611);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 15;
            label3.Text = "第 1 頁 / 共 N 頁";
            // 
            // button1
            // 
            button1.Location = new Point(429, 606);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "上一頁";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(694, 606);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "下一頁";
            button2.UseVisualStyleBackColor = true;
            // 
            // ProductMangagement
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 677);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(counterDropdown);
            Controls.Add(vendorDropdown);
            Controls.Add(btnAddVendor);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearchVendor);
            Controls.Add(searchProductBox);
            Name = "ProductMangagement";
            Text = "Form1";
            Load += ProductMangagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CounterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void VendorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtSearchVendor_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSearchVendor_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnAddVendor;
        private DataGridView dataGridView1;
        private Button btnSearchVendor;
        private TextBox searchProductBox;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Image;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Vendor;
        private DataGridViewTextBoxColumn Counter;
        private DataGridViewTextBoxColumn Action;
        private ComboBox vendorDropdown;
        private ComboBox counterDropdown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}