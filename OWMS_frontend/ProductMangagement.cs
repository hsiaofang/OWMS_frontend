//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWMS_frontend
{
    public partial class ProductMangagement : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private int currentPage = 1;
        private int totalPages = 1;
        private const int pageSize = 10;
        public ProductMangagement()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            string vendorResponse = await _httpClient.GetStringAsync("http://127.0.0.1:7001/api/vendors");
            string counterResponse = await _httpClient.GetStringAsync("http://127.0.0.1:7001/api/cabinets");

            List<string> vendors = JsonSerializer.Deserialize<List<string>>(vendorResponse);
            List<string> cabinets = JsonSerializer.Deserialize<List<string>>(counterResponse);

            vendorDropdown.Items.Clear();
            vendorDropdown.Items.Add("所有廠商");
            vendorDropdown.Items.AddRange(vendors.ToArray());
            vendorDropdown.SelectedIndex = 0;

            counterDropdown.Items.Clear();
            counterDropdown.Items.Add("所有櫃號");
            counterDropdown.Items.AddRange(cabinets.ToArray());
            counterDropdown.SelectedIndex = 0;

            string url = $"http://127.0.0.1:7001/api/products?pageNumber={currentPage}&pageSize={pageSize}" +
                         $"&vendor={vendorDropdown.SelectedItem}&counter={counterDropdown.SelectedItem}";
            string productResponse = await _httpClient.GetStringAsync(url);

            var responseData = JsonSerializer.Deserialize<ApiResponse>(productResponse);
            totalPages = (int)Math.Ceiling((double)responseData.TotalProducts / pageSize);

            // 🔽 更新分页信息
            UpdatePagination();

            // 🔽 显示产品数据
            UpdateProductGrid(responseData.Products);
        }

        private void UpdatePagination()
        {
            lblPageInfo.Text = $"第 {currentPage} 页 / 共 {totalPages} 页";
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
        }
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = searchProductBox.Text;
                string selectedVendor = vendorDropdown.SelectedItem?.ToString() ?? "所有廠商";
                string selectedCabinet = counterDropdown.SelectedItem?.ToString() ?? "所有櫃號";

                // 🔹 組裝 API 查詢參數
                string url = $"http://127.0.0.1:7001/api/products?search={searchText}&vendor={selectedVendor}&cabinet={selectedCabinet}";

                string response = await _httpClient.GetStringAsync(url);
                List<Product> products = JsonSerializer.Deserialize<List<Product>>(response);

                // 更新 DataGridView
                UpdateProductGrid(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜尋失敗: {ex.Message}");
            }
        }

        // 🔹 更新 DataGridView
        private void UpdateProductGrid(List<Product> products)
        {
            productGridView.Rows.Clear();
            foreach (var product in products)
            {
                productGridView.Rows.Add(product.Name, product.Price, product.Vendor, product.Cabinet, product.Image, product.QRCode);
            }
        }

        private void ProductMangagement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
}
