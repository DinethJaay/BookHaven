using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;

namespace BookHaven.Data.Repositories.CustomerManagementRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString;
        public CustomerRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }
        /// <summary>
        /// Add a new customer to the database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Customer AddCustomer(Customer customer)
        {
            Customer addedCustomer = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"INSERT INTO Customer (FirstName, LastName, Email, PhoneNumber, DateOfBirth, Gender, Address, City, ZipCode,IsDeleted,CreatedAt,UpdatedAt)
                                     VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @DateOfBirth, @Gender, @Address, @City, @ZipCode,@IsDeleted,@CreatedAt,@UpdatedAt)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                        cmd.Parameters.AddWithValue("@Email", customer.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                        cmd.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", customer.Gender);
                        cmd.Parameters.AddWithValue("@Address", customer.Address);
                        cmd.Parameters.AddWithValue("@City", customer.City);
                        cmd.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
                        cmd.Parameters.AddWithValue("@IsDeleted", false);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            addedCustomer = customer;
                            addedCustomer.CustomerId = Convert.ToInt32(result);
                            if (!string.IsNullOrEmpty(customer.Email))
                            {
                                SendEmail(customer.Email);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while adding the customer to the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while customer the book.", ex);
            }

            return addedCustomer;
        }
        /// <summary>
        /// Delete a customer from the database
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DeleteCustomer(int customerId)
        {
            bool isDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"UPDATE Customer SET IsDeleted = 1 WHERE CustomerId = @CustomerId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        isDeleted = rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while deleting the customer from the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while deleting the customer.", ex);
            }
            return isDeleted;
        }

        /// <summary>
        /// Edit a customer in the database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool EditCustomer(Customer customer)
        {
            bool isUpdated = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"UPDATE Customer
                             SET FirstName = @FirstName,
                                 LastName = @LastName,
                                 Email = @Email,
                                 PhoneNumber = @PhoneNumber,
                                 DateOfBirth = @DateOfBirth,
                                 Gender = @Gender,
                                 Address = @Address,
                                 City = @City,
                                 ZipCode = @ZipCode,
                                 IsDeleted = @IsDeleted,
                                 UpdatedAt = @UpdatedAt
                             WHERE CustomerId = @CustomerId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                        cmd.Parameters.AddWithValue("@Email", customer.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                        cmd.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", customer.Gender);
                        cmd.Parameters.AddWithValue("@Address", customer.Address);
                        cmd.Parameters.AddWithValue("@City", customer.City);
                        cmd.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
                        cmd.Parameters.AddWithValue("@IsDeleted", customer.IsDeleted); 
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isUpdated = true;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while updating the customer information in the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while updating the customer information.", ex);
            }

            return isUpdated;

     }
        /// <summary>
        /// Get all customers from the database
        /// </summary>
        /// <param name="searchparam"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Customer> GetAllCustomers(string searchparam)
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                  
                    string query = @"
                SELECT CustomerId, FirstName, LastName, Email, PhoneNumber, DateOfBirth, Gender, Address, City, ZipCode
                FROM Customer
                WHERE IsDeleted = 0 
                AND (FirstName LIKE @SearchParam OR LastName LIKE @SearchParam OR Email LIKE @SearchParam);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@SearchParam", "%" + searchparam + "%");

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                              
                                Customer customer = new Customer
                                {
                                    CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerId")),
                                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    City = reader.GetString(reader.GetOrdinal("City")),
                                    ZipCode = reader.GetString(reader.GetOrdinal("ZipCode"))
                                };
                                customers.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                throw new Exception("An error occurred while fetching the customers from the database.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
                throw new Exception("An unexpected error occurred while fetching the customers.", ex);
            }

            return customers;
        }
        /// <summary>
        /// Send an email to the customer
        /// </summary>
        /// <param name="recipientEmail"></param>
        private void SendEmail(string recipientEmail)
        {
            try
            {
                string senderEmail = "dinethjayanga37@gmail.com"; // Change to your email
                string senderPassword = "aeljetiqkxabowfr"; // Change to your email password
                string smtpServer = "smtp.gmail.com"; // Change to your SMTP server
                int smtpPort = 587; // Change to the correct SMTP port

                string emailBody = @"
        <html>
        <head>
            <style>
                body { font-family: Arial, sans-serif; background-color: #f4f4f4; margin: 0; padding: 20px; }
                .container { max-width: 600px; background: #ffffff; padding: 20px; border-radius: 10px; box-shadow: 0 4px 8px rgba(0,0,0,0.1); }
                .header { background: #4CAF50; color: white; text-align: center; padding: 10px; font-size: 22px; border-radius: 10px 10px 0 0; }
                .content { padding: 20px; text-align: center; font-size: 16px; color: #333; }
                .footer { margin-top: 20px; text-align: center; font-size: 14px; color: #777; }
                .button { display: inline-block; padding: 12px 20px; background-color: #4CAF50; color: white; text-decoration: none; border-radius: 5px; font-weight: bold; }
                .button:hover { background-color: #45a049; }
            </style>
        </head>
        <body>
            <div class='container'>
                <div class='header'>🎉 Welcome to Book Heaven! 📚</div>
                <div class='content'>
                    <p>Dear Customer,</p>
                    <p>We are thrilled to welcome you to <strong>Book Heaven</strong>! 📖✨</p>
                    <p>Explore a world of amazing books and exclusive content just for you.</p>
                    <p>Click the button below to start your journey:</p>
                    <a class='button' href='#'>Explore Now</a>
                </div>
                <div class='footer'>
                    <p>Happy Reading! 📚</p>
                    <p>&copy; 2025 Book Heaven. All Rights Reserved.</p>
                </div>
            </div>
        </body>
        </html>";

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "🎉 Welcome to Book Heaven!";
                    mail.Body = emailBody;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }

    }
}
