namespace OWMS_frontend
{
    partial class VendorManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtSearchVendor = new TextBox();
            btnSearchVendor = new Button();
            dataGridView1 = new DataGridView();
            VendorName = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            btnAddVendor = new Button();
            btnAddNumber = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(17, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(69, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "廠商管理";
            // 
            // txtSearchVendor
            // 
            txtSearchVendor.Location = new Point(17, 78);
            txtSearchVendor.Name = "txtSearchVendor";
            txtSearchVendor.Size = new Size(125, 27);
            txtSearchVendor.TabIndex = 1;
            txtSearchVendor.Text = "搜尋廠商名稱：";
            txtSearchVendor.TextChanged += txtSearchVendor_TextChanged;
            // 
            // btnSearchVendor
            // 
            btnSearchVendor.Location = new Point(164, 76);
            btnSearchVendor.Name = "btnSearchVendor";
            btnSearchVendor.Size = new Size(94, 29);
            btnSearchVendor.TabIndex = 2;
            btnSearchVendor.Text = "🔍 搜尋";
            btnSearchVendor.UseVisualStyleBackColor = true;
            btnSearchVendor.Click += btnSearchVendor_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { VendorName, Type, Contact, Action });
            dataGridView1.Location = new Point(12, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(633, 292);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // VendorName
            // 
            VendorName.HeaderText = "廠商名稱";
            VendorName.MinimumWidth = 6;
            VendorName.Name = "VendorName";
            VendorName.Width = 125;
            // 
            // Type
            // 
            Type.HeaderText = "類型";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Contact
            // 
            Contact.HeaderText = "聯絡人";
            Contact.MinimumWidth = 6;
            Contact.Name = "Contact";
            Contact.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "操作";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Width = 125;
            // 
            // btnAddVendor
            // 
            btnAddVendor.Location = new Point(22, 118);
            btnAddVendor.Name = "btnAddVendor";
            btnAddVendor.Size = new Size(122, 28);
            btnAddVendor.TabIndex = 4;
            btnAddVendor.Text = "+ 新增廠商\t";
            btnAddVendor.UseVisualStyleBackColor = true;
            // 
            // btnAddNumber
            // 
            btnAddNumber.Location = new Point(164, 118);
            btnAddNumber.Name = "btnAddNumber";
            btnAddNumber.Size = new Size(122, 28);
            btnAddNumber.TabIndex = 5;
            btnAddNumber.Text = "+ 新增區間單號\t";
            btnAddNumber.UseVisualStyleBackColor = true;
            // 
            // VendorManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnAddNumber);
            Controls.Add(btnAddVendor);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearchVendor);
            Controls.Add(txtSearchVendor);
            Controls.Add(lblTitle);
            Name = "VendorManagement";
            Text = "Form1";
            Load += VendorManagement_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtSearchVendor;
        private Button btnSearchVendor;
        private DataGridView dataGridView1;
        private Button btnAddVendor;
        private DataGridViewTextBoxColumn VendorName;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Action;
        private Button btnAddNumber;
    }
}