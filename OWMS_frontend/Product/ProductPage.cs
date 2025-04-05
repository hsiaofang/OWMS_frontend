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
                string vendors = await _httpClient.GetStringAsync($"{apiUrl}/vendor");

                var vendorData = JsonConvert.DeserializeObject<VendorResponse>(vendors);
                MessageBox.Show("廠商資料：" + JsonConvert.SerializeObject(vendorData));
                vendorDropdown.Items.Clear();
                foreach (var vendor in vendorData.Vendors)
                {
                    vendorDropdown.Items.Add(vendor.Name);
                }

                string counters = await _httpClient.GetStringAsync($"{apiUrl}/counter");
                MessageBox.Show("櫃號 JSON：" + counters);
                var counterData = JsonConvert.DeserializeObject<CounterResponse>(counters);
                if (counterData?.Counters != null && counterData.Counters.Any())
                {
                    MessageBox.Show("櫃號資料：" + JsonConvert.SerializeObject(counterData));
                    counterDropdown.Items.Clear();
                    foreach (var counter in counterData.Counters)
                    {
                        counterDropdown.Items.Add(counter.Name);
                    }
                }

                await LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"資料載入失敗: {ex.Message}");
            }
        }

        private async Task LoadProduct()
        {
            try
            {
                string selectedVendor = vendorDropdown.SelectedItem?.ToString() ?? "所有廠商";
                string selectedCounter = counterDropdown.SelectedItem?.ToString() ?? "所有櫃號";

                string url = $"{apiUrl}/products?pageNumber={currentPage}&pageSize={pageSize}" +
                             $"&vendor={Uri.EscapeDataString(selectedVendor)}&counter={Uri.EscapeDataString(selectedCounter)}";

                var response = await _httpClient.GetAsync(url);
                string productResponse = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"載入產品失敗 ({(int)response.StatusCode}):\n{productResponse}");
                    return;
                }

                var responseData = JsonConvert.DeserializeObject<ProductResponse>(productResponse);

                totalPages = (int)Math.Ceiling((double)responseData.TotalProducts / pageSize);

                // 更新頁面資料
                UpdatePagination();
                UpdateProductGrid(responseData.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入產品失敗: {ex.Message}");
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var addProductForm = new Create())
            {
                addProductForm.ShowDialog();
                if (addProductForm.IsConfirmed)
                {
                    LoadProduct();
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
                LoadProduct();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadProduct();
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

        public class ProductResponse
        {
            public int TotalProducts { get; set; }
            public List<Product> Products { get; set; }
        }

        //public class VendorResponse
        //{
        //    public string Result { get; set; }
        //    public List<Vendor> Vendors { get; set; }
        //    public int TotalVendors { get; set; }
        //    public int TotalPages { get; set; }
        //    public int CurrentPage { get; set; }
        //}

        public class Vendor
        {
            public int VendorId { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Account { get; set; }
            public string Password { get; set; }
            public string Notes { get; set; }
            public List<BatchNumber> BatchNumbers { get; set; }
        }
        public class CounterResponse
        {
            public string Result { get; set; }
            public List<Counter> Counters { get; set; }
            //public IEnumerable<object> Counter { get; internal set; }
        }
        public class Counter
        {
            public int CounterId { get; set; }
            public string Name { get; set; }
            // 其他屬性
        }

        public class BatchNumber
        {
            public int Id { get; set; }
            public string BatchCode { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int Quantity { get; set; }
            public DateTime CreatedAt { get; set; }
            public string Notes { get; set; }
        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
