using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace OWMS_frontend
{
    public partial class Login : Form
    {
        private string apiUrl;
        private readonly HttpClient _httpClient;

        public Login()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            apiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請輸入用戶名和密碼");
                return;
            }

            var homePage = new HomePage();
            homePage.Show();
            this.Hide();
            //try
            //{
            //    var requestBody = new
            //    {
            //        Username = username,
            //        Password = password
            //    };

            //    var jsonContent = JsonConvert.SerializeObject(requestBody);
            //    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            //    string requestUrl = $"{apiUrl}/auth/login";
            //    MessageBox.Show($"請求的路由: {requestUrl}");

            //    var response = await _httpClient.PostAsync(requestUrl, content);

            //    if (response.IsSuccessStatusCode)
            //    {
            //        var responseBody = await response.Content.ReadAsStringAsync();
            //        var token = JsonConvert.DeserializeObject<dynamic>(responseBody)?.token;

            //        MessageBox.Show($"登入成功！Token: {token}");

            //        var homePage = new HomePage();
            //        homePage.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        var errorResponse = await response.Content.ReadAsStringAsync();
            //        MessageBox.Show($"登入失敗: {errorResponse}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"發生錯誤: {ex.Message}");
            //}
        }

        private void tabRegister_Click(object sender, EventArgs e)
        {
            // 註冊邏輯，如果有需要的話
        }
    }
}