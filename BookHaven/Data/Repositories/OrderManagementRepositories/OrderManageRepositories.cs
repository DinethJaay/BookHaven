using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;

namespace BookHaven.Data.Repositories.OrderManagementRepositories
{
    public class OrderManageRepositories : IOrderManageRepositories
    {
        private readonly string _connectionString;

        public OrderManageRepositories()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }
        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT CustomerId, FirstName, LastName, PhoneNumber, Email, Address FROM Customer";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            CustomerId = Convert.ToInt32(reader["CustomerId"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString()
                        });
                    }
                }
            }

            return customers;
        }
        /// <summary>
        ///     Get all books
        /// </summary>
        /// <returns></returns>
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT BookId, Title, Author, ISBN, Price, StockQuantity FROM Book";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            BookId = Convert.ToInt32(reader["BookId"]),
                            Title = reader["Title"].ToString(),
                            Author = reader["Author"].ToString(),
                
                            ISBN = reader["ISBN"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            StockQuantity = Convert.ToInt32(reader["StockQuantity"])
                        });
                    }
                }
            }

            return books;
        }

        /// <summary>
        /// Save order
        /// </summary>
        /// <param name="order"></param>
        public void SaveOrder(Order order)
        {
           
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO [Order] ([CustomerId], [BookId], [Quantity], [Price], [Subtotal], [DeliveryType], [Status], [OrderDate]) " +
                               "VALUES (@CustomerId, @BookId, @Quantity, @Price, @Subtotal, @DeliveryType, @Status, @OrderDate); " +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                    command.Parameters.AddWithValue("@BookId", order.BookId);
                    command.Parameters.AddWithValue("@Quantity", order.Quantity);
                    command.Parameters.AddWithValue("@Price", order.Price);
                    command.Parameters.AddWithValue("@Subtotal", order.Subtotal);
                    command.Parameters.AddWithValue("@DeliveryType", order.DeliveryType);
                    command.Parameters.AddWithValue("@Status", order.Status);
                    command.Parameters.AddWithValue("@OrderDate", order.OrderDate);

                    connection.Open();
                    object result = command.ExecuteScalar(); // Retrieve the generated Order ID

                    if (result != null)
                    {
                        order.OrderId = Convert.ToInt32(result); // Set the generated Order ID in the Order object
                    }
                }
            }
        }

        /// <summary>
        /// Get all orders
        /// </summary>
        /// <returns></returns>
        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT OrderId, CustomerId, BookId, Quantity, Price, Subtotal, DeliveryType, Status, OrderDate FROM [Order]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = Convert.ToInt32(reader["OrderId"]),
                            CustomerId = Convert.ToInt32(reader["CustomerId"]),
                            BookId = Convert.ToInt32(reader["BookId"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Subtotal = Convert.ToDecimal(reader["Subtotal"]),
                            DeliveryType = reader["DeliveryType"].ToString(),
                            Status = reader["Status"].ToString(),
                            OrderDate = reader["OrderDate"] != DBNull.Value ? (DateTime)reader["OrderDate"] : DateTime.MinValue
                        });
                    }
                }
            }

            return orders;
        }
        /// <summary>
        /// Get order by id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order GetOrderById(int orderId)
        {
            Order order = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM [Order] WHERE OrderId = @OrderId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        order = new Order
                        {
                            OrderId = Convert.ToInt32(reader["OrderId"]),
                            CustomerId = Convert.ToInt32(reader["CustomerId"]),
                            BookId = Convert.ToInt32(reader["BookId"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Subtotal = Convert.ToDecimal(reader["Subtotal"]),
                            DeliveryType = reader["DeliveryType"].ToString(),
                            Status = reader["Status"].ToString(),
                            OrderDate = reader["OrderDate"] != DBNull.Value ? (DateTime)reader["OrderDate"] : DateTime.MinValue
                        };
                    }
                }
            }

            return order;
        }
        /// <summary>
        /// Update order status
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool UpdateOrderStatus(Order order)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE [Order] SET Status = @Status WHERE OrderId = @OrderId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", order.OrderId);
                    command.Parameters.AddWithValue("@Status", order.Status);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0; // Return true if the update was successful, otherwise false
                }
            }
        }
        /// <summary>
        ///     Update book stock
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public bool UpdateBookStock(int bookId, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Book SET StockQuantity = StockQuantity - @Quantity WHERE BookId = @BookId AND StockQuantity >= @Quantity";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0; // Return true if the stock was updated
                }
            }
        }

    }
}
