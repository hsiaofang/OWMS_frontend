

namespace OWMS_frontend.Product
{
    partial class ProductDialog
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
            btnCancel = new Button();
            btnConfirm = new Button();
            cmbStatus = new CheckBox();
            lblStatus = new Label();
            btnSelectImage = new Button();
            lblImage = new Label();
            lblVendor = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            label1 = new Label();
            vendorDropdown = new ComboBox();
            counterDropdown = new ComboBox();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(676, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(49, 39);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(565, 380);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(49, 39);
            btnConfirm.TabIndex = 40;
            btnConfirm.Text = "確定";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.AutoSize = true;
            cmbStatus.Location = new Point(163, 319);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(18, 17);
            cmbStatus.TabIndex = 39;
            cmbStatus.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(75, 317);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 19);
            lblStatus.TabIndex = 38;
            lblStatus.Text = "狀態:";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(287, 240);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(99, 28);
            btnSelectImage.TabIndex = 35;
            btnSelectImage.Text = "選擇圖片...";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(76, 249);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(42, 19);
            lblImage.TabIndex = 34;
            lblImage.Text = "圖片:";
            // 
            // lblVendor
            // 
            lblVendor.AutoSize = true;
            lblVendor.Location = new Point(76, 155);
            lblVendor.Name = "lblVendor";
            lblVendor.Size = new Size(42, 19);
            lblVendor.TabIndex = 32;
            lblVendor.Text = "廠商:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(164, 95);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(101, 27);
            txtPrice.TabIndex = 31;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(76, 95);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(72, 19);
            lblPrice.TabIndex = 30;
            lblPrice.Text = "產品價格:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(164, 49);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(101, 27);
            txtProductName.TabIndex = 29;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(75, 49);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(72, 19);
            lblProductName.TabIndex = 28;
            lblProductName.Text = "產品名稱:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 155);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 42;
            label1.Text = "櫃號:";
            // 
            // vendorDropdown
            // 
            vendorDropdown.FormattingEnabled = true;
            vendorDropdown.Location = new Point(164, 147);
            vendorDropdown.Name = "vendorDropdown";
            vendorDropdown.Size = new Size(140, 27);
            vendorDropdown.TabIndex = 44;
            vendorDropdown.Text = "全部";
            vendorDropdown.SelectedIndexChanged += vendorDropdown_SelectedIndexChanged;
            // 
            // counterDropdown
            // 
            counterDropdown.FormattingEnabled = true;
            counterDropdown.Location = new Point(414, 147);
            counterDropdown.Name = "counterDropdown";
            counterDropdown.Size = new Size(140, 27);
            counterDropdown.TabIndex = 45;
            counterDropdown.Text = "全部";
            counterDropdown.SelectedIndexChanged += counterDropdown_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(164, 203);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(92, 65);
            pictureBox.TabIndex = 46;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // ProductDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(counterDropdown);
            Controls.Add(vendorDropdown);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(btnSelectImage);
            Controls.Add(lblImage);
            Controls.Add(lblVendor);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Name = "ProductDialog";
            Text = "Form1";
            Load += ProductDialog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void counterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void vendorDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Button btnCancel;
        private Button btnConfirm;
        private CheckBox cmbStatus;
        private Label lblStatus;
        private Button btnSelectImage;
        private Label lblImage;
        private Label lblVendor;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtProductName;
        private Label lblProductName;
        private Label label1;
        private ComboBox vendorDropdown;
        private ComboBox counterDropdown;
        private PictureBox pictureBox;
    }
}