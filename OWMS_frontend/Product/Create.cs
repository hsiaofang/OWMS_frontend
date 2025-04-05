using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Windows.Forms;

namespace OWMS_frontend.Product
{
    public partial class Create : Form
    {
        public bool IsConfirmed { get; private set; } = false;

        public Create()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtVendor.Text))
            {
                MessageBox.Show("請填寫所有必填欄位！");
                return;
            }

            IsConfirmed = true;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
