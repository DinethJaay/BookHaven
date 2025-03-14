﻿using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Presentation.Comman;

namespace BookHaven.Presentation.Admin
{
    public partial class SupplierOrderForm : Form
    {
        private readonly ISupplierOrderManagementService _supplierOrderService;

        public SupplierOrderForm(ISupplierOrderManagementService supplierOrderService)
        {
            InitializeComponent();
            _supplierOrderService = supplierOrderService ?? throw new ArgumentNullException(nameof(supplierOrderService));
            LoadSuppliers();
            LoadLowStockBooks();
            LoadSupplierOrders();
        }
        private void LoadSuppliers()
        {
            cmbsupplier.Items.Clear();
            List<Supplier> suppliers = _supplierOrderService.GetAllSuppliers();

            foreach (var supplier in suppliers)
            {
                cmbsupplier.Items.Add(supplier.SupplierName);
            }
        }
        private void LoadSupplierOrders()
        {
            dtgorderreq.Columns.Clear(); // Clear existing columns (if any)
            dtgorderreq.Rows.Clear();

            // Define Columns
            dtgorderreq.Columns.Add("SupplierOrderID", "Order ID");
            dtgorderreq.Columns.Add("SupplierName", "Supplier Name");
            dtgorderreq.Columns.Add("BookTitle", "Book Title");
            dtgorderreq.Columns.Add("Quantity", "Quantity");
            dtgorderreq.Columns.Add("OrderDate", "Order Date");
            dtgorderreq.Columns.Add("Status", "Status");
            dtgorderreq.Columns.Add(new DataGridViewTextBoxColumn { Name = "BookID", HeaderText = "Book ID", Visible = true });


            // Fetch Supplier Orders with Supplier and Book details
            List<SupplierOrder> orders = _supplierOrderService.GetSupplierOrdersWithDetails();

            foreach (var order in orders)
            {
                dtgorderreq.Rows.Add(
                    order.SupplierOrderID,
                    order.Supplier.SupplierName,
                    order.Book.Title,
                    order.Quantity,
                    order.OrderDate.ToString("yyyy-MM-dd"),
                    order.Status,
                     order.BookID
                );
            }
        }


        private void LoadLowStockBooks()
        {
            dtgsupplierorder.Columns.Clear(); 
            dtgsupplierorder.Rows.Clear();

            // Define Columns
            dtgsupplierorder.Columns.Add("BookId", "Book ID");
            dtgsupplierorder.Columns.Add("Title", "Title");
            dtgsupplierorder.Columns.Add("Author", "Author");
            dtgsupplierorder.Columns.Add("StockQuantity", "Stock Quantity");
            dtgsupplierorder.Columns.Add("Price", "Price");

            // Fetch Books with Stock < 20
            List<Book> lowStockBooks = _supplierOrderService.GetLowStockBooks();

            foreach (var book in lowStockBooks)
            {
                dtgsupplierorder.Rows.Add(book.BookId, book.Title, book.Author, book.StockQuantity, book.Price);
            }
        }

        private void cmbsupplier_TextChanged(object sender, EventArgs e)
        {
            SearchSupplier();
        }

        private void SearchSupplier()
        {
            string searchText = cmbsupplier.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText)) return;

            // Get suppliers that contain the entered text
            var matchingSuppliers = _supplierOrderService.GetAllSuppliers()
                .Where(s => s.SupplierName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(s => s.SupplierName)
                .ToList();

            cmbsupplier.Items.Clear();
            cmbsupplier.Items.AddRange(matchingSuppliers.Select(s => s.SupplierName).ToArray());

            cmbsupplier.DroppedDown = matchingSuppliers.Any();
            cmbsupplier.SelectionStart = cmbsupplier.Text.Length;
            cmbsupplier.SelectionLength = 0;
        }


        private void cmbsupplier_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user presses Enter, perform the search and open the dropdown
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Prevents the dropdown from closing on Enter key press
                SearchSupplier(); // Perform the search based on the typed text

                // Ensure the dropdown stays open with suggestions
                cmbsupplier.DroppedDown = true;
            }
        }


        private void cmbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgsupplierorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            if (cmbsupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtgsupplierorder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int supplierID = _supplierOrderService.GetAllSuppliers()
                .FirstOrDefault(s => s.SupplierName == cmbsupplier.SelectedItem.ToString())?.SupplierID ?? -1;

            if (supplierID == -1)
            {
                MessageBox.Show("Invalid supplier selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dtgsupplierorder.SelectedRows[0];
            int bookID = Convert.ToInt32(selectedRow.Cells["BookId"].Value);
            // Get quantity from txtnewstock TextBox
            if (!int.TryParse(txtnewstock.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SupplierOrder order = new SupplierOrder
            {
                SupplierID = supplierID,
                BookID = bookID,
                Quantity = quantity,
                OrderDate = DateTime.Now,
                Status = "Pending"
            };

            try
            {
                _supplierOrderService.SaveSupplierOrder(order);
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLowStockBooks(); 
                LoadSupplierOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdatestatus_Click(object sender, EventArgs e)
        {
            if (dtgorderreq.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dtgorderreq.SelectedRows[0];
            int supplierOrderID = Convert.ToInt32(selectedRow.Cells["SupplierOrderID"].Value);
            int bookID = Convert.ToInt32(selectedRow.Cells["BookID"].Value);
            int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

            string newStatus = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newStatus == "Delivered")
            {
                MessageBox.Show("Updating stock for BookID: " + bookID + " with Quantity: " + quantity, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _supplierOrderService.UpdateBookStock(bookID, quantity);
                MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Send Email Notification
                var supplier = _supplierOrderService.GetAllSuppliers().FirstOrDefault(s => s.SupplierID == supplierOrderID);
                if (supplier != null)
                {
                    SendEmailNotification(supplier.SupplierName, supplier.Email, bookID, quantity);
                }
            }
        }
        private void SendEmailNotification(string supplierName, string supplierEmail, int bookId, int quantity)
        {
            try
            {
                string subject = "📦 Order Delivered Successfully - BookHaven";

                string body = $@"
        <html>
        <head>
            <style>
                body {{ font-family: Arial, sans-serif; background-color: #f4f4f4; margin: 0; padding: 20px; }}
                .container {{ max-width: 600px; background: #ffffff; padding: 20px; border-radius: 10px;
                             box-shadow: 0 4px 8px rgba(0,0,0,0.1); text-align: center; }}
                .header {{ background: #3498db; color: white; padding: 15px; font-size: 22px;
                           border-radius: 10px 10px 0 0; }}
                .content {{ padding: 20px; font-size: 16px; color: #333; }}
                .footer {{ margin-top: 20px; text-align: center; font-size: 14px; color: #777; }}
                .button {{ display: inline-block; padding: 12px 20px; background-color: #3498db; color: white;
                           text-decoration: none; border-radius: 5px; font-weight: bold; margin-top: 15px; }}
                .button:hover {{ background-color: #2980b9; }}
            </style>
        </head>
        <body>
            <div class='container'>
                <div class='header'>📢 Order Delivered Notification</div>
                <div class='content'>
                    <p>Dear <strong>{supplierName}</strong>,</p>
                    <p>Your order has been successfully delivered.</p>
                    <p><strong>Order Details:</strong></p>
                    <p>📘 <strong>Book ID:</strong> {bookId}</p>
                    <p>📦 <strong>Quantity:</strong> {quantity}</p>
                    <p>Thank you for your business and trust in <strong>BookHaven</strong>.</p>
                    <a class='button' href='#'>View Order Details</a>
                </div>
                <div class='footer'>
                    <p>Best Regards,</p>
                    <p><strong>BookHaven Team</strong></p>
                    <p>&copy; 2025 BookHaven. All Rights Reserved.</p>
                </div>
            </div>
        </body>
        </html>";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("dinethjayanga37@gmail.com", "BookHaven");
                mail.To.Add(supplierEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true; // Enable HTML formatting

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("dinethjayanga37@gmail.com", "aeljetiqkxabowfr");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dtgorderreq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedOrder = dtgorderreq.Rows[e.RowIndex];

                // Get Order ID, Quantity, and Status
                int supplierOrderID = Convert.ToInt32(selectedOrder.Cells["SupplierOrderID"].Value);
                int quantity = Convert.ToInt32(selectedOrder.Cells["Quantity"].Value);
                string status = selectedOrder.Cells["Status"].Value.ToString();

                // Populate text fields
                txtnewstock.Text = quantity.ToString();
                comboBox1.SelectedItem = status;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }
    }
}
