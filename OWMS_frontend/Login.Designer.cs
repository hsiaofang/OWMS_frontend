
using Newtonsoft.Json;
using System.Text;

namespace OWMS_frontend
{
    partial class Login
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
            tabControl1 = new TabControl();
            tabRegister = new TabPage();
            label2 = new Label();
            label1 = new Label();
            tabLogin = new TabPage();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabRegister.SuspendLayout();
            tabLogin.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabRegister);
            tabControl1.Controls.Add(tabLogin);
            tabControl1.Location = new Point(143, 115);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(399, 248);
            tabControl1.TabIndex = 0;
            // 
            // tabRegister
            // 
            tabRegister.Controls.Add(label2);
            tabRegister.Controls.Add(label1);
            tabRegister.Location = new Point(4, 28);
            tabRegister.Name = "tabRegister";
            tabRegister.Padding = new Padding(3);
            tabRegister.Size = new Size(391, 216);
            tabRegister.TabIndex = 0;
            tabRegister.Text = "註冊";
            tabRegister.UseVisualStyleBackColor = true;
            tabRegister.Click += tabRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 110);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 1;
            label2.Text = "密碼";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 0;
            label1.Text = "帳號";
            // 
            // tabLogin
            // 
            tabLogin.Controls.Add(btnLogin);
            tabLogin.Controls.Add(txtPassword);
            tabLogin.Controls.Add(txtUsername);
            tabLogin.Controls.Add(label4);
            tabLogin.Controls.Add(label3);
            tabLogin.Location = new Point(4, 28);
            tabLogin.Name = "tabLogin";
            tabLogin.Padding = new Padding(3);
            tabLogin.Size = new Size(391, 216);
            tabLogin.TabIndex = 1;
            tabLogin.Text = "登入";
            tabLogin.UseVisualStyleBackColor = true;
            tabLogin.Click += tabLogin_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(176, 171);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "登入";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(124, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(146, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtUsername_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(124, 49);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(146, 27);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 133);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 2;
            label4.Text = "密碼";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 57);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 1;
            label3.Text = "帳號";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Login";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabRegister.ResumeLayout(false);
            tabRegister.PerformLayout();
            tabLogin.ResumeLayout(false);
            tabLogin.PerformLayout();
            ResumeLayout(false);
        }

        private void tabLogin_Click(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabRegister;
        private Label label2;
        private Label label1;
        private TabPage tabLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Button btnLogin;
    }
}