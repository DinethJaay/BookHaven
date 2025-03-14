using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Repositories.DashboardManagementRepository;
using BookHaven.Presentation.Admin;
using BookHaven.Presentation.Comman;

namespace BookHaven.Presentation.Staff
{
    public partial class SalesClerkDashboard : Form
    {
        private readonly IDashboardManagementService _dashboardManagementService;
        public SalesClerkDashboard()
        {
            _dashboardManagementService = new DashboardManagementService(new DashboardRepository());
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void SalesClerkDashboard_Load(object sender, EventArgs e)
        {
            // Fetch Daily Sales Count
            var dailySalesCount = await _dashboardManagementService.GetDailySalesCount();
            lbldailySales.Text = dailySalesCount.ToString();

            // Fetch Daily Sales Amount
            var dailySalesAmount = await _dashboardManagementService.GetDailySalesAmount();
            lblweeklySales.Text = dailySalesAmount.ToString("C");

            // Fetch Total Orders
            var totalOrders = await _dashboardManagementService.GetTotalOrdersCount();
            lbltotalorders.Text = totalOrders.ToString();

            // Fetch Pending Orders
            var pendingOrders = await _dashboardManagementService.GetPendingOrdersCount();
            lblpendingorders.Text = pendingOrders.ToString();

            // Fetch Completed Orders
            var completedOrders = await _dashboardManagementService.GetCompletedOrdersCount();
            lblcompletedorders.Text = completedOrders.ToString();

            // Fetch Total Customers
            var totalCustomers = await _dashboardManagementService.GetTotalCustomersCount();
            lbltotalcustomers.Text = totalCustomers.ToString();

            // Fetch Total Suppliers
            var totalSuppliers = await _dashboardManagementService.GetTotalSuppliersCount();
            lbltotalsuppliers.Text = totalSuppliers.ToString();

            // Fetch Total Books
            var totalBooks = await _dashboardManagementService.GetTotalBooksCount();
            lbltotalbooks.Text = totalBooks.ToString();

            // Fetch Most Selling Book
            var mostSellingBook = await _dashboardManagementService.GetMostSellingBook();
            lblmostselling.Text = mostSellingBook?.Title ?? "No data";
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
           
            BookInventoryViewForm salesClarkDashboard = new BookInventoryViewForm();
            salesClarkDashboard.ShowDialog();
           
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
           
            CustomerManagementViewForm customerManagementView = new CustomerManagementViewForm();
            customerManagementView.ShowDialog();
           
        }

        private void btnsalestransaction_Click(object sender, EventArgs e)
        {
            
            SalesTransactionForm salesTransactionForm = new SalesTransactionForm();
            salesTransactionForm.ShowDialog();

        }

        private void btnordermanagement_Click(object sender, EventArgs e)
        {

            OrderAdd orderAddForm = new OrderAdd();
            orderAddForm.Show();

        }

        private void btnreporting_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesReportDaily salesReportDaily = new SalesReportDaily();
            salesReportDaily.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

    }
}
