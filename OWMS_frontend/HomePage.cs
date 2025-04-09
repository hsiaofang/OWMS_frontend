using System;
using System.Windows.Forms;

namespace OWMS_frontend
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            ShowUserControl(new ProductPage());
        }

        private void ShowUserControl(UserControl userControl)
        {
            this.panelContainer.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(userControl);
        }

        private void 產品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ProductPage());
        }

        private void 廠商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(new VendorPage());

        }

        private void 庫存管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 審核管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
