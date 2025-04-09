using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using OWMS_frontend.Apis;
using System.Net.Http.Headers;
using System.Configuration;
using Newtonsoft.Json;
using static OWMS_frontend.ProductPage;

namespace OWMS_frontend.Product
{
    public partial class ProductDialog : Form
    {
        public ProductItem ProductItem { get; set; }
        public bool IsConfirmed { get; private set; }

        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public ProductDialog()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _apiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        }

         private void ProductDialog_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public ProductDialog(ProductItem productItem) : this()
        {
            ProductItem = productItem;

            if (ProductItem != null)
            {
                txtProductName.Text = ProductItem.ProductName;
                txtPrice.Text = ProductItem.Price.ToString();
                vendorDropdown.Text = ProductItem.Vendor?.VendorName;
                counterDropdown.Text = ProductItem.Counter?.CounterName;
                //pictureBox.Image = Image.FromFile(ProductItem.PhotoUrl);
            }
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ProductItem == null)
                {
                    ProductItem = new ProductItem();
                }

                ProductItem.ProductName = txtProductName.Text;
                ProductItem.Price = int.Parse(txtPrice.Text);
                ProductItem.Vendor = (Apis.Vendor)vendorDropdown.SelectedItem;
                ProductItem.Counter = (Apis.Counter)counterDropdown.SelectedItem;

                var requestData = new MultipartFormDataContent();

                var jsonContent = new StringContent(JsonConvert.SerializeObject(ProductItem), System.Text.Encoding.UTF8, "application/json");
                requestData.Add(jsonContent, "productItem");

                if (pictureBox.Image != null && !string.IsNullOrEmpty(pictureBox.ImageLocation))
                {
                    var fileStream = new FileStream(pictureBox.ImageLocation, FileMode.Open, FileAccess.Read);
                    var fileName = Path.GetFileName(pictureBox.ImageLocation);
                    var fileContentPart = new StreamContent(fileStream);
                    fileContentPart.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

                    requestData.Add(fileContentPart, "image", fileName);
                }

                var url = $"{_apiUrl}/products/create";
                var response = await _httpClient.PostAsync(url, requestData);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ProductItem>(responseString);

                    if (result != null && result.PhotoUrl != null)
                    {
                        ProductItem.PhotoUrl = result.PhotoUrl;
                    }

                    IsConfirmed = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"API error: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Select Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(filePath);
            }
        }
    }
}
