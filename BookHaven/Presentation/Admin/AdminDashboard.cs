using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Repositories;
using BookHaven.Data.Repositories.DashboardManagementRepository;
using BookHaven.Data.Repositories.ReportManagementRepository;
using BookHaven.Presentation.Comman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Presentation.Admin
{
    public partial class AdminDashboard : Form
    {
        private readonly IUserService _userService;
        private readonly IDashboardManagementService _dashboardManagementService;

        public AdminDashboard()
        {
            _dashboardManagementService = new DashboardManagementService(new DashboardRepository());
            _userService = new UserService(new UserManageRepository());
            InitializeComponent();
        }

        private async void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Fetch Daily Sales Count
            var dailySalesCount = await _dashboardManagementService.GetDailySalesCount();
            lbldailySales.Text = dailySalesCount.ToString();

            // Fetch Weekly Sales Count
            var weeklySalesCount = await _dashboardManagementService.GetWeeklySalesCount();
            lblweeklySales.Text = weeklySalesCount.ToString();

            // Fetch Monthly Sales Count
            var monthlySalesCount = await _dashboardManagementService.GetMonthlySalesCount();
            lblmonthlySales.Text = monthlySalesCount.ToString();

            // Fetch Daily Sales Amount
            var dailySalesAmount = await _dashboardManagementService.GetDailySalesAmount();
            lbltotaldailyamount.Text = dailySalesAmount.ToString("C");

            // Fetch Weekly Sales Amount
            var weeklySalesAmount = await _dashboardManagementService.GetWeeklySalesAmount();
            totalweeklyamount.Text = weeklySalesAmount.ToString("C");

            // Fetch Monthly Sales Amount
            var monthlySalesAmount = await _dashboardManagementService.GetMonthlySalesAmount();
            lblmonthlyamount.Text = monthlySalesAmount.ToString("C");

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
            this.Hide();
            BookInventoryViewForm bookInventory = new BookInventoryViewForm();
            bookInventory.ShowDialog();
            this.Close();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

        }

        private void menupicbox_Click(object sender, EventArgs e)
        {
            sidebartimer.Start(); //Correct timer reference
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement userManagementForm = new UserManagement(_userService);
            userManagementForm.Show();
        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSupplier addSupplierForm = new AddSupplier();
            addSupplierForm.Show();
        }

        private void btnorderrequest_Click(object sender, EventArgs e)
        {
            ISupplierOrderManagementService supplierOrderService = new SupplierOrderManagementService();
            SupplierOrderForm supplierOrderForm = new SupplierOrderForm(supplierOrderService);
            this.Hide();
            supplierOrderForm.Show();
        }

        private void btnordermanagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderAdd orderAddForm = new OrderAdd();
            orderAddForm.Show();

        }

        private void Overview_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManagementViewForm customerManagement = new CustomerManagementViewForm();
            customerManagement.ShowDialog();
            this.Close();
        }

        private void btnsalestransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesTransactionForm salesTransactios = new SalesTransactionForm();
            salesTransactios.ShowDialog();
            this.Close();
        }

        private void btnreporting_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportDashboard reportDashboard = new ReportDashboard();
            reportDashboard.ShowDialog();
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
