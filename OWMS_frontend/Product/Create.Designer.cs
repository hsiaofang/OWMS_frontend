

namespace OWMS_frontend.Product
{
    partial class Create
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
            btnGenerateQRCode = new Button();
            lblQRCode = new Label();
            btnSelectImage = new Button();
            lblImage = new Label();
            txtVendor = new TextBox();
            lblVendor = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(676, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(49, 39);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(565, 380);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(49, 39);
            btnConfirm.TabIndex = 26;
            btnConfirm.Text = "確定";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += this.btnConfirm_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.AutoSize = true;
            cmbStatus.Location = new Point(164, 211);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(18, 17);
            cmbStatus.TabIndex = 25;
            cmbStatus.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(76, 215);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 19);
            lblStatus.TabIndex = 24;
            lblStatus.Text = "狀態:";
            // 
            // btnGenerateQRCode
            // 
            btnGenerateQRCode.Location = new Point(164, 333);
            btnGenerateQRCode.Name = "btnGenerateQRCode";
            btnGenerateQRCode.Size = new Size(99, 28);
            btnGenerateQRCode.TabIndex = 23;
            btnGenerateQRCode.Text = "生成QRCode";
            btnGenerateQRCode.UseVisualStyleBackColor = true;
            // 
            // lblQRCode
            // 
            lblQRCode.AutoSize = true;
            lblQRCode.Location = new Point(76, 342);
            lblQRCode.Name = "lblQRCode";
            lblQRCode.Size = new Size(71, 19);
            lblQRCode.TabIndex = 22;
            lblQRCode.Text = "QRCode:";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(164, 283);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(99, 28);
            btnSelectImage.TabIndex = 21;
            btnSelectImage.Text = "選擇圖片...";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += this.btnSelectImage_Click;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(76, 292);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(42, 19);
            lblImage.TabIndex = 20;
            lblImage.Text = "圖片:";
            // 
            // txtVendor
            // 
            txtVendor.Location = new Point(164, 147);
            txtVendor.Name = "txtVendor";
            txtVendor.Size = new Size(101, 27);
            txtVendor.TabIndex = 19;
            txtVendor.TextChanged += txtVendor_TextChanged;
            // 
            // lblVendor
            // 
            lblVendor.AutoSize = true;
            lblVendor.Location = new Point(76, 155);
            lblVendor.Name = "lblVendor";
            lblVendor.Size = new Size(42, 19);
            lblVendor.TabIndex = 18;
            lblVendor.Text = "廠商:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(164, 94);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(101, 27);
            txtPrice.TabIndex = 17;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(76, 102);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(42, 19);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "價格:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(164, 31);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(101, 27);
            txtProductName.TabIndex = 15;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(76, 39);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(72, 19);
            lblProductName.TabIndex = 14;
            lblProductName.Text = "產品名稱:";
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(btnGenerateQRCode);
            Controls.Add(lblQRCode);
            Controls.Add(btnSelectImage);
            Controls.Add(lblImage);
            Controls.Add(txtVendor);
            Controls.Add(lblVendor);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Name = "Create";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtVendor_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private Button btnCancel;
        private Button btnConfirm;
        private CheckBox cmbStatus;
        private Label lblStatus;
        private Button btnGenerateQRCode;
        private Label lblQRCode;
        private Button btnSelectImage;
        private Label lblImage;
        private TextBox txtVendor;
        private Label lblVendor;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtProductName;
        private Label lblProductName;
    }
}