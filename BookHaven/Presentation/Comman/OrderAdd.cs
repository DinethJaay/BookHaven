using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.OrderManagementRepositories;
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
using BookHaven.Presentation.Admin;

namespace BookHaven.Presentation.Comman
{
    public partial class OrderAdd : Form
    {
        private readonly IOrderManagementService _orderService;
        public OrderAdd()
        {
            InitializeComponent();
            _orderService = new OrderManagementService(new OrderManageRepositories());
            // Initialize DataGridView columns
            InitializeDataGridViews();
            LoadCustomers();
            LoadBooks();
        }
        private void InitializeDataGridViews()
        {
            // Initialize dtgcustomerdeatils DataGridView columns
            dtgcustomerdeatils.Columns.Clear();
            dtgcustomerdeatils.Columns.Add("CustomerId", "Customer ID");
            dtgcustomerdeatils.Columns.Add("FirstName", "First Name");
            dtgcustomerdeatils.Columns.Add("LastName", "Last Name");
            dtgcustomerdeatils.Columns.Add("Email", "Email");
            dtgcustomerdeatils.Columns.Add("Address", "Address");

            // Initialize dtgsearchbook DataGridView columns
            dtgsearchbook.Columns.Clear();
            dtgsearchbook.Columns.Add("BookId", "Book ID");
            dtgsearchbook.Columns.Add("Title", "Title");
            dtgsearchbook.Columns.Add("Author", "Author");
            dtgsearchbook.Columns.Add("Price", "Price");
            dtgsearchbook.Columns.Add("StockQuantity", "Stock Quantity");
        }

        private void LoadCustomers()
        {
            try
            {
                List<Customer> customers = _orderService.GetCustomerByPhone("");

                if (customers != null && customers.Count > 0)
                {
                    cmbsearchphone.DataSource = customers;
                    cmbsearchphone.DisplayMember = "PhoneNumber"; 
                    cmbsearchphone.ValueMember = "CustomerId"; 
                }
                else
                {
                    cmbsearchphone.DataSource = null;
                    MessageBox.Show("No customers found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooks()
        {
            List<Book> books = _orderService.GetBookByTitle("");
            cmbsearchbook.DataSource = books;
            cmbsearchbook.DisplayMember = "Title";
            cmbsearchbook.ValueMember = "BookId";
        }
        private void cmbsearchphone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsearchphone.SelectedItem != null)
            {
                // Cast the selected item to Customer object
                Customer selectedCustomer = cmbsearchphone.SelectedItem as Customer;

                if (selectedCustomer != null)
                {
                    // Clear existing data in the grid view before adding new data
                    dtgcustomerdeatils.Rows.Clear();

                    // Add the selected customer details to the DataGridView
                    dtgcustomerdeatils.Rows.Add(
                        selectedCustomer.CustomerId,
                        selectedCustomer.FirstName,
                        selectedCustomer.LastName,
                        selectedCustomer.Email,
                        selectedCustomer.Address
                    );
                }
            }

        }

        private void cmbsearchbook_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (cmbsearchbook.SelectedItem != null)
            {
                // Cast the selected item to a Book object
                Book selectedBook = cmbsearchbook.SelectedItem as Book;

                if (selectedBook != null)
                {
                    // Clear the DataGridView before adding the new row
                    dtgsearchbook.Rows.Clear();

                    // Add the selected book's details to the DataGridView
                    dtgsearchbook.Rows.Add(
                        selectedBook.BookId,
                        selectedBook.Title,
                        selectedBook.Author,
                        selectedBook.Genre,
                        selectedBook.Price,
                        selectedBook.StockQuantity
                    );
                }
                else
                {
                    MessageBox.Show("Selected book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dtgcustomerdeatils_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               //retrieve the CustomerId or other data from the clicked row
                var customerId = dtgcustomerdeatils.Rows[e.RowIndex].Cells[0].Value;
               
            }
        }

        private void dtgsearchbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Get the BookId from the selected row
                var bookId = dtgsearchbook.Rows[e.RowIndex].Cells[0].Value;

                // Use the bookId to fetch the book details
                OrderManageRepositories repository = new OrderManageRepositories();
                Book selectedBook = repository.GetBooks().FirstOrDefault(b => b.BookId == (int)bookId);

                if (selectedBook != null)
                {
                    
                    MessageBox.Show($"Title: {selectedBook.Title}\nAuthor: {selectedBook.Author}\nGenre: {selectedBook.Genre}\nPrice: {selectedBook.Price}",
                                    "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            // Validate Customer Selection
            if (cmbsearchphone.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Book Selection
            if (cmbsearchbook.SelectedItem == null)
            {
                MessageBox.Show("Please select a book.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cast selected items
            Customer selectedCustomer = cmbsearchphone.SelectedItem as Customer;
            Book selectedBook = cmbsearchbook.SelectedItem as Book;

            // Validate Quantity Input
            if (string.IsNullOrWhiteSpace(txtbookqunity.Text) || !int.TryParse(txtbookqunity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity (positive number).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Price Input
            if (string.IsNullOrWhiteSpace(txtbookprice.Text) || !decimal.TryParse(txtbookprice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter a valid price (positive number).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if stock is available
            if (quantity > selectedBook.StockQuantity)
            {
                MessageBox.Show($"Quantity exceeds available stock. Only {selectedBook.StockQuantity} books are available.",
                                "Quantity Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Delivery Type
            string deliveryType = GetDeliveryType();
            if (string.IsNullOrWhiteSpace(deliveryType))
            {
                MessageBox.Show("Please select a delivery type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate subtotal
            decimal subtotal = quantity * price;

            // Create Order Object
            var order = new Order
            {
                CustomerId = selectedCustomer.CustomerId,
                BookId = selectedBook.BookId,
                Quantity = quantity,
                Price = price,
                Subtotal = subtotal,
                Status = "Pending",
                DeliveryType = deliveryType,
                OrderDate = DateTime.Now
            };

            try
            {
                _orderService.SaveOrder(order);
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Send confirmation email
                SendOrderConfirmationEmail(selectedCustomer.Email, order);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDeliveryType()
        {
            List<string> selectedDeliveryTypes = new List<string>();

            foreach (var item in chkdiliverydetails.CheckedItems)
            {
                selectedDeliveryTypes.Add(item.ToString());
            }

            return string.Join(", ", selectedDeliveryTypes);
        }

        // Save order to database
        private void SaveOrderToDatabase(Order order)
        {
            // Call the SaveOrder method to save the order to the database
            _orderService.SaveOrder(order);
        }
        // Subtotal Calculation
        private void txtBookQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtbookqunity.Text, out int quantity) && decimal.TryParse(txtbookprice.Text, out decimal price))
            {
                decimal subtotal = quantity * price;
                lblsubtotal.Text = $"Subtotal: {subtotal:C}";
            }
            else
            {
                lblsubtotal.Text = "Invalid quantity or price.";
            }
        }

        private void UpdateSubtotal()
        {
            if (int.TryParse(txtbookqunity.Text, out int quantity) && decimal.TryParse(txtbookprice.Text, out decimal price))
            {
                decimal subtotal = quantity * price;
                lblsubtotal.Text = $" {subtotal:C}";
            }
            else
            {
                lblsubtotal.Text = "Invalid quantity or price.";
            }
        }

        private void txtbookqunity_TextChanged(object sender, EventArgs e)
        {
            UpdateSubtotal();
        }

        private void txtbookprice_TextChanged(object sender, EventArgs e)
        {
            UpdateSubtotal();
        }

        private void SendOrderConfirmationEmail(string recipientEmail, Order order)
        {
            try
            {
                string senderEmail = "dinethjayanga37@gmail.com"; // Your email
                string senderPassword = "aeljetiqkxabowfr"; // Your email password
                string smtpServer = "smtp.gmail.com"; // Gmail SMTP server
                int smtpPort = 587; // Gmail SMTP port

                string subject = $"Order Confirmation - Order ID: {order.OrderId}";

                // Email body with UI improvements (HTML)
                string body = $@"
        <html>
        <head>
            <style>
                body {{ font-family: Arial, sans-serif; background-color: #f4f4f4; margin: 0; padding: 20px; }}
                .container {{ max-width: 600px; background: #ffffff; padding: 20px; border-radius: 10px;
                             box-shadow: 0 4px 8px rgba(0,0,0,0.1); text-align: left; }}
                .header {{ background: #0073e6; color: white; padding: 15px; font-size: 22px;
                           border-radius: 10px 10px 0 0; text-align: center; }}
                .content {{ padding: 20px; font-size: 16px; color: #333; }}
                .footer {{ margin-top: 20px; text-align: center; font-size: 14px; color: #777; }}
                .button {{ display: inline-block; padding: 12px 20px; background-color: #0073e6; color: white;
                           text-decoration: none; border-radius: 5px; font-weight: bold; margin-top: 15px; }}
                .button:hover {{ background-color: #005bb5; }}
                .info-box {{ background: #f8f9fa; padding: 10px; border-left: 4px solid #0073e6; margin: 10px 0; }}
            </style>
        </head>
        <body>
            <div class='container'>
                <div class='header'>📢 Order Confirmation</div>
                <div class='content'>
                    <p>Thank you for your order! Below are your order details:</p>
                    <div class='info-box'>
                        <p><strong>Order ID:</strong> {order.OrderId}</p>
                        <p><strong>Book Title:</strong> {_orderService.GetBookByTitle("").FirstOrDefault(b => b.BookId == order.BookId)?.Title}</p>
                        <p><strong>Quantity:</strong> {order.Quantity}</p>
                        <p><strong>Total Price:</strong> {order.Subtotal:C}</p>
                        <p><strong>Delivery Type:</strong> {order.DeliveryType}</p>
                    </div>
                    <p>Your order is currently <strong>PENDING</strong>. We will notify you once it is shipped.</p>
                    <a class='button' href='#'>Track Your Order</a>
                </div>
                <div class='footer'>
                    <p>Best Regards,</p>
                    <p><strong>BookHaven Team</strong></p>
                </div>
            </div>
        </body>
        </html>";

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true; // Enable HTML formatting

                    using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }

                MessageBox.Show("Order confirmation email sent successfully!", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnmanageorder_Click(object sender, EventArgs e)
        {
            // Create an instance of the OrderManageRepositories
            IOrderManageRepositories orderRepo = new OrderManageRepositories();

            // Initialize service with the repository
            IOrderManagementService orderService = new OrderManagementService(orderRepo);

            // Create an instance of OrderManage form and pass the service
            OrderManage orderManageForm = new OrderManage(orderService);
            this.Hide();
            // Show the OrderManage form (non-blocking, new window)
            orderManageForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }
    }

}
