
using Newtonsoft.Json;

namespace OWMS_frontend
{
    partial class ProductPage
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
            btnNext = new Button();
            btnPrev = new Button();
            lblPageInfo = new Label();
            label2 = new Label();
            label1 = new Label();
            counterDropdown = new ComboBox();
            vendorDropdown = new ComboBox();
            btnAddProduct = new Button();
            productGridView = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Image = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            vendors = new DataGridViewTextBoxColumn();
            counters = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            btnSearch = new Button();
            searchProductBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Location = new Point(659, 598);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 28;
            btnNext.Text = "下一頁";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(394, 598);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 29);
            btnPrev.TabIndex = 27;
            btnPrev.Text = "上一頁";
            btnPrev.UseVisualStyleBackColor = true;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(511, 603);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(120, 19);
            lblPageInfo.TabIndex = 26;
            lblPageInfo.Text = "第 1 頁 / 共 N 頁";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(929, 85);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 25;
            label2.Text = "櫃號篩選：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 85);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 24;
            label1.Text = "廠商篩選：";
            // 
            // counterDropdown
            // 
            counterDropdown.FormattingEnabled = true;
            counterDropdown.Location = new Point(1019, 82);
            counterDropdown.Name = "counterDropdown";
            counterDropdown.Size = new Size(149, 27);
            counterDropdown.TabIndex = 23;
            counterDropdown.Text = "全部";
            // 
            // vendorDropdown
            // 
            vendorDropdown.FormattingEnabled = true;
            vendorDropdown.Location = new Point(749, 82);
            vendorDropdown.Name = "vendorDropdown";
            vendorDropdown.Size = new Size(140, 27);
            vendorDropdown.TabIndex = 22;
            vendorDropdown.Text = "全部";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(56, 81);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(122, 28);
            btnAddProduct.TabIndex = 21;
            btnAddProduct.Text = "+ 新增產品\t";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // productGridView
            // 
            productGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.Columns.AddRange(new DataGridViewColumn[] { ProductName, Price, Image, Code, vendors, counters, Status, Action });
            productGridView.Location = new Point(46, 157);
            productGridView.Name = "productGridView";
            productGridView.RowHeadersWidth = 51;
            productGridView.Size = new Size(1268, 415);
            productGridView.TabIndex = 20;
            productGridView.CellContentClick += btnEditProduct_Click;
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
            // vendors
            // 
            vendors.HeaderText = "所屬廠商";
            vendors.MinimumWidth = 6;
            vendors.Name = "vendors";
            vendors.Width = 125;
            // 
            // counters
            // 
            counters.HeaderText = "所屬櫃號";
            counters.MinimumWidth = 6;
            counters.Name = "counters";
            counters.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "狀態";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "操作";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Text = "編輯";
            Action.UseColumnTextForButtonValue = true;
            Action.Width = 125;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1220, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "🔍 搜尋";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // searchProductBox
            // 
            searchProductBox.Location = new Point(496, 83);
            searchProductBox.Name = "searchProductBox";
            searchProductBox.Size = new Size(125, 27);
            searchProductBox.TabIndex = 18;
            searchProductBox.Text = "搜尋產品名稱";
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(lblPageInfo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(counterDropdown);
            Controls.Add(vendorDropdown);
            Controls.Add(btnAddProduct);
            Controls.Add(productGridView);
            Controls.Add(btnSearch);
            Controls.Add(searchProductBox);
            Name = "ProductPage";
            Size = new Size(1902, 1033);
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button btnNext;
        private Button btnPrev;
        private Label lblPageInfo;
        private Label label2;
        private Label label1;
        private ComboBox counterDropdown;
        private ComboBox vendorDropdown;
        private Button btnAddProduct;
        private DataGridView productGridView;
        private Button btnSearch;
        private TextBox searchProductBox;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Image;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn vendors;
        private DataGridViewTextBoxColumn counters;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Action;
    }
}