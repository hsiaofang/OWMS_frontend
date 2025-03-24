using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OWMS_frontend
{
    public partial class ProductPage : Form
    {
        private string selectedImagePath = "";

        public ProductPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "選擇產品圖片",
                Filter = "圖片檔案 (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pbProductImage.Image = Image.FromFile(selectedImagePath);
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = lalProductName.Text;
            int vendorId = cbVendor.SelectedIndex + 1;
            int counterId = cbCounter.SelectedIndex + 1;

            if (string.IsNullOrEmpty(name) || vendorId == 0 || counterId == 0)
            {
                MessageBox.Show("請填寫完整的產品資訊！");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                var formData = new MultipartFormDataContent();

                formData.Add(new StringContent(name), "Name");
                formData.Add(new StringContent(vendorId.ToString()), "VendorId");
                formData.Add(new StringContent(counterId.ToString()), "CounterId");

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    var imageBytes = File.ReadAllBytes(selectedImagePath);
                    var imageContent = new ByteArrayContent(imageBytes);
                    imageContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                    formData.Add(imageContent, "ImageFile", Path.GetFileName(selectedImagePath));
                }


                HttpResponseMessage response = await client.PostAsync("http://localhost:5000/Product/Create", formData);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("產品新增成功！");
                }
                else
                {
                    MessageBox.Show("新增產品失敗：" + await response.Content.ReadAsStringAsync());
                }
            }
        }

    }
}
