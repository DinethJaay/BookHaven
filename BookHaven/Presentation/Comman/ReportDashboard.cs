using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Presentation.Admin;

namespace BookHaven.Presentation.Comman
{
    public partial class ReportDashboard : Form
    {
        public ReportDashboard()
        {
            InitializeComponent();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesReportView salesReportView = new SalesReportView();
            salesReportView.ShowDialog();
            this.Close();

        }

        private void btnBestBooksSelling_Click(object sender, EventArgs e)
        {
            this.Hide();
            MostBooksSaleView mostBooksSaleView = new MostBooksSaleView();
            mostBooksSaleView.ShowDialog();
            this.Close();
        }

        private void btnInventoryStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryStatusView bookInventoryViewForm = new InventoryStatusView();
            bookInventoryViewForm.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }
    }
}
