
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
            tabLogin = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 110);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 1;
            label2.Text = "密碼";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 133);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 2;
            label4.Text = "密碼";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(124, 49);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(146, 27);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += this.textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(124, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(146, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += this.txtUsername_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(176, 171);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "登入";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += this.btnLogin_Click;
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // 假設有一個 TextBox 用來輸入使用者名稱
            string password = txtPassword.Text; // 假設有一個 TextBox 用來輸入密碼

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("使用者名稱和密碼不得為空！");
                return;
            }

            var loginRequest = new
            {
                Username = username,
                Password = password
            };


            string url = "https://localhost:5000/api/Auth/login";

            // 創建 HttpClient 來發送請求
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // 將 loginRequest 轉換為 JSON 並發送 POST 請求
                var jsonContent = new StringContent(JsonConvert.SerializeObject(loginRequest), Encoding.UTF8, "application/json");

                // 發送請求並接收回應
                HttpResponseMessage response = await client.PostAsync(url, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    // 如果登入成功，取得返回的 JWT Token
                    string token = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("登入成功，獲取到 Token：" + token);
                    // 這裡可以將 Token 存儲在某個地方（如本地存儲，或傳遞到其他頁面）
                }
                else
                {
                    // 如果登入失敗，顯示錯誤訊息
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("登入失敗：" + errorMessage);
                }
            }
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