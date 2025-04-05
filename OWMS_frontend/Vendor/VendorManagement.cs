using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using OWMS_frontend.Apis;

namespace OWMS_frontend
{
    public partial class VendorManagement : Form
    {
        private int currentPage = 1;
        private int pageSize = 10;
        private object lblPageInfo;
        private object textBox1;

        public VendorManagement()
        {
            InitializeComponent();
        }

        private async void VendorManagement_Load(object sender, EventArgs e)
        {
            await LoadVendors();
        }

        private async Task LoadVendors()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:5000/api/vendor?page={currentPage}&pageSize={pageSize}";
                var response = await client.GetStringAsync(url);

                var vendorsResponse = JsonConvert.DeserializeObject<VendorsResponse>(response);

                var vendors = vendorsResponse.Data.ToList();

                dataGridView1.DataSource = vendors;

                //lblPageInfo.Text = $"Page {vendorsResponse.CurrentPage} of {vendorsResponse.TotalPages}";
            }
        }



        private async void btnSearchVendor_Click(object sender, EventArgs e)
        {
            //string searchTerm = textBox1.ToLower();

            //if (string.IsNullOrEmpty(searchTerm))
            //{
            //    await LoadVendors();
            //}
            //else
            //{
            //    var filteredVendors = vendors.Where(v => v.Name.ToLower().Contains(searchTerm) ||
            //                                              v.Contact.ToLower().Contains(searchTerm) ||
            //                                              v.Phone.Contains(searchTerm) ||
            //                                              v.Email.ToLower().Contains(searchTerm)).ToList();

            //    dataGridView1.DataSource = filteredVendors;
            //}
        }

        private void VendorManagement_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchVendor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
