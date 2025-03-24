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
            lalProductName = new Label();
            lblCounter = new Label();
            lblVendor = new Label();
            txtProductName = new TextBox();
            cbVendor = new ComboBox();
            cbCounter = new ComboBox();
            lblPhoto = new Label();
            pbProductImage = new PictureBox();
            btnSubmit = new Button();
            btnSelectImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // lalProductName
            // 
            lalProductName.AutoSize = true;
            lalProductName.Location = new Point(143, 102);
            lalProductName.Name = "lalProductName";
            lalProductName.Size = new Size(76, 19);
            lalProductName.TabIndex = 0;
            lalProductName.Text = "產品名稱 :";
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(143, 211);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(76, 19);
            lblCounter.TabIndex = 1;
            lblCounter.Text = "櫃號清單 :";
            lblCounter.Click += label1_Click;
            // 
            // lblVendor
            // 
            lblVendor.AutoSize = true;
            lblVendor.Location = new Point(143, 153);
            lblVendor.Name = "lblVendor";
            lblVendor.Size = new Size(76, 19);
            lblVendor.TabIndex = 2;
            lblVendor.Text = "廠商清單 :";
            lblVendor.Click += label2_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(264, 94);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 3;
            txtProductName.TextChanged += textBox1_TextChanged;
            // 
            // cbVendor
            // 
            cbVendor.FormattingEnabled = true;
            cbVendor.Location = new Point(264, 143);
            cbVendor.Name = "cbVendor";
            cbVendor.Size = new Size(128, 27);
            cbVendor.TabIndex = 4;
            cbVendor.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbCounter
            // 
            cbCounter.FormattingEnabled = true;
            cbCounter.Location = new Point(264, 211);
            cbCounter.Name = "cbCounter";
            cbCounter.Size = new Size(128, 27);
            cbCounter.TabIndex = 5;
            cbCounter.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lblPhoto
            // 
            lblPhoto.AutoSize = true;
            lblPhoto.Location = new Point(143, 277);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(76, 19);
            lblPhoto.TabIndex = 6;
            lblPhoto.Text = "產品圖片 :";
            // 
            // pbProductImage
            // 
            pbProductImage.Location = new Point(264, 252);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(130, 86);
            pbProductImage.TabIndex = 7;
            pbProductImage.TabStop = false;
            pbProductImage.Click += pictureBox1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(214, 381);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "提交";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(419, 272);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(94, 29);
            btnSelectImage.TabIndex = 9;
            btnSelectImage.Text = "選擇圖片";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelectImage);
            Controls.Add(btnSubmit);
            Controls.Add(pbProductImage);
            Controls.Add(lblPhoto);
            Controls.Add(cbCounter);
            Controls.Add(cbVendor);
            Controls.Add(txtProductName);
            Controls.Add(lblVendor);
            Controls.Add(lblCounter);
            Controls.Add(lalProductName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lalProductName;
        private Label lblCounter;
        private Label lblVendor;
        private TextBox txtProductName;
        private ComboBox cbVendor;
        private ComboBox cbCounter;
        private Label lblPhoto;
        private PictureBox pbProductImage;
        private Button btnSubmit;
        private Button btnSelectImage;
    }
}