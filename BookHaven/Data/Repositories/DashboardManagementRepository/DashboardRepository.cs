using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;

namespace BookHaven.Data.Repositories.DashboardManagementRepository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly string _connectionString;
        public DashboardRepository() {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }
        /// <summary>
        /// Fetch Sales Count by Date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public async Task<int> FetchSalesCountByDate(DateTime date)
        {
            var query = @"
                SELECT COUNT(*) 
                FROM CustomerTransactions
                WHERE CAST(Date AS DATE) = @Date";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Date", date);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        /// <summary>
        /// Fetch Sales Count by Date Range
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public async Task<int> FetchSalesCountByDateRange(DateTime startDate, DateTime endDate)
        {
            var query = @"
                SELECT COUNT(*) 
                FROM CustomerTransactions
                WHERE Date BETWEEN @StartDate AND @EndDate";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        /// <summary>
        /// Fetch Sales Amount by Date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public async Task<decimal> FetchSalesAmountByDate(DateTime date)
        {
            var query = @"
                SELECT SUM(TotalAmount) 
                FROM CustomerTransactions
                WHERE CAST(Date AS DATE) = @Date";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Date", date);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        /// <summary>
        /// Fetch Sales Amount by Date Range
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public async Task<decimal> FetchSalesAmountByDateRange(DateTime startDate, DateTime endDate)
        {
            var query = @"
                SELECT SUM(TotalAmount) 
                FROM CustomerTransactions
                WHERE Date BETWEEN @StartDate AND @EndDate";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        /// <summary>
        /// Fetch Total Orders Count
        /// </summary>
        /// <returns></returns>
        public async Task<int> FetchTotalOrdersCount()
        {
            var query = "SELECT COUNT(*) FROM [Order]";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }
        /// <summary>
        /// Fetch Orders Count by Status
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public async Task<int> FetchOrdersCountByStatus(string status)
        {
            var query = "SELECT COUNT(*) FROM [Order] WHERE Status = @Status";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        /// <summary>
        /// Fetch Total Customers Count
        /// </summary>
        /// <returns></returns>
        public async Task<int> FetchTotalCustomersCount()
        {
            var query = "SELECT COUNT(*) FROM Customer";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        /// <summary>
        /// Fetch Total Suppliers Count
        /// </summary>
        /// <returns></returns>
        public async Task<int> FetchTotalSuppliersCount()
        {
            var query = "SELECT COUNT(*) FROM Supplier";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        /// <summary>
        /// Fetch Total Books Count
        /// </summary>
        /// <returns></returns>
        public async Task<int> FetchTotalBooksCount()
        {
            var query = "SELECT COUNT(*) FROM Book";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }
        /// <summary>
        ///     Fetch Most Selling Book
        /// </summary>
        /// <returns></returns>
        public async Task<Book> FetchMostSellingBook()
        {
            var query = @"
                SELECT TOP 1 b.BookId, b.Title, SUM(s.Quantity) AS TotalQuantity
                FROM SalesTransactionDetails s
                INNER JOIN Book b ON s.BookId = b.BookId
                GROUP BY b.BookId, b.Title
                ORDER BY TotalQuantity DESC";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new Book
                        {
                            BookId = reader.GetInt32(reader.GetOrdinal("BookId")),
                            Title = reader.GetString(reader.GetOrdinal("Title"))
                        };
                    }
                }
            }
            return null;
        }
    }
}
