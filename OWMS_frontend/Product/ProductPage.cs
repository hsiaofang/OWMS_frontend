using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json;
using OWMS_frontend.Apis;
using OWMS_frontend.Product;
using System.Reflection.Metadata;
using System.Security.Policy;

namespace OWMS_frontend
{
    public partial class ProductPage : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private string apiUrl;
        private int currentPage = 1;
        private const int pageSize = 10;
        private int totalPages = 1;

        public ProductPage()
        {
            InitializeComponent();
            apiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            LoadPage();
        }
        private async Task LoadPage()
        {
            try
            {
                string url = $"{apiUrl}/products?pageNumber={currentPage}&pageSize={pageSize}";
                var response = await _httpClient.GetAsync(url);
                string productResponse = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"載入產品失敗 ({(int)response.StatusCode}):{productResponse}");
                    return;
                }

                var responseData = JsonConvert.DeserializeObject<ProductResponse>(productResponse);

                totalPages = (int)Math.Ceiling((double)responseData.TotalProducts / pageSize);
                UpdatePagination();

                UpdateProductGrid(responseData.Products);

                vendorDropdown.Items.Clear();
                foreach (var vendor in responseData.Vendors)
                {
                    vendorDropdown.Items.Add(vendor);
                }

                counterDropdown.Items.Clear();
                foreach (var counter in responseData.Counters)
                {
                    counterDropdown.Items.Add(counter);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化資料失敗: {ex.Message}");
            }
        }



        private void UpdatePagination()
        {
            lblPageInfo.Text = $"第 {currentPage} 頁 / 共 {totalPages} 頁";
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
        }

        private void UpdateProductGrid(List<Product> products)
        {
            foreach (var product in products)
            {
                productGridView.Rows.Add(
                    product.ProductName,
                    product.Price,
                    product.Vendor.Name,
                    product.Counter.Name,
                    product.PhotoUrl,
                    product.QRCode
                );
            }
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var addProductForm = new ProductDialog())
            {
                var result = addProductForm.ShowDialog();

                if (result == DialogResult.OK && addProductForm.IsConfirmed)
                {
                    await LoadPage();
                }
            }
        }

        private void btnEditProduct_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (productGridView.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                var row = productGridView.Rows[e.RowIndex];

                string productName = row.Cells[0].Value?.ToString();
                decimal productPrice = Convert.ToDecimal(row.Cells[1].Value);
                string vendorName = row.Cells[2].Value?.ToString();
                string counterName = row.Cells[3].Value?.ToString();
                string productPhotoUrl = row.Cells[4].Value?.ToString();
                string productQRCode = row.Cells[5].Value?.ToString();

                var selectedProduct = new ProductItem
                {
                    ProductName = productName,
                    Price = (int)productPrice,
                    Vendor = new OWMS_frontend.Apis.Vendor { VendorName = vendorName },
                    Counter = new OWMS_frontend.Apis.Counter { CounterName = counterName },
                    PhotoUrl = productPhotoUrl,
                    QRCode = productQRCode
                };


                using (var editProductForm = new ProductDialog(selectedProduct))
                {
                    var result = editProductForm.ShowDialog();

                    if (result == DialogResult.OK && editProductForm.IsConfirmed)
                    {
                        LoadPage();
                    }
                }
            }
        }


        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = searchProductBox.Text;
                string selectedVendor = vendorDropdown.SelectedItem?.ToString() ?? "所有廠商";
                string selectedCabinet = counterDropdown.SelectedItem?.ToString() ?? "所有櫃號";

                string url = $"{apiUrl}/products?search={Uri.EscapeDataString(searchText)}&vendor={Uri.EscapeDataString(selectedVendor)}&cabinet={Uri.EscapeDataString(selectedCabinet)}";

                string response = await _httpClient.GetStringAsync(url);
                var responseData = JsonConvert.DeserializeObject<ProductResponse>(response);
                List<Product> products = responseData.Products;

                UpdateProductGrid(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜尋失敗: {ex.Message}");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage();
            }
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
        }

        private void vendorDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void searchProductBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void counterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public class Product
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public Vendor Vendor { get; set; }
            public Counter Counter { get; set; }
            public string PhotoUrl { get; set; }
            public string QRCode { get; set; }
        }

        public class Vendor
        {
            public int VendorId { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Account { get; set; }
            public string Password { get; set; }
            public string Notes { get; set; }
        }


        public class Counter
        {
            public int CounterId { get; set; }
            public string Name { get; set; }
        }

        public class ProductResponse
        {
            public string Result { get; set; }
            public string Message { get; set; }
            public int TotalProducts { get; set; }
            public int TotalPages { get; set; }
            public int CurrentPage { get; set; }
            public int PageSize { get; set; }
            public List<Product> Products { get; set; }
            public List<string> Vendors { get; set; }
            public List<string> Counters { get; set; }
        }



        private async void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productGridView.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                var row = productGridView.Rows[e.RowIndex];

                string productName = row.Cells[0].Value?.ToString();
                decimal productPrice = Convert.ToDecimal(row.Cells[1].Value);
                string vendorName = row.Cells[2].Value?.ToString();
                string counterName = row.Cells[3].Value?.ToString();
                string productPhotoUrl = row.Cells[4].Value?.ToString();
                string productQRCode = row.Cells[5].Value?.ToString();

                var selectedProduct = new ProductItem
                {
                    ProductName = productName,
                    Price = (int)productPrice,
                    Vendor = new OWMS_frontend.Apis.Vendor { VendorName = vendorName },
                    Counter = new OWMS_frontend.Apis.Counter { CounterName = counterName },
                    PhotoUrl = productPhotoUrl,
                    QRCode = productQRCode
                };

                using (var editProductForm = new ProductDialog(selectedProduct))
                {
                    var result = editProductForm.ShowDialog();

                    if (result == DialogResult.OK && editProductForm.IsConfirmed)
                    {
                        await LoadPage();
                    }
                }
            }
        }


    }
}
