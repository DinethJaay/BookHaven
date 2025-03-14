using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Data.Repositories.DashboardManagementRepository
{
    public interface IDashboardRepository
    {
        Task<int> FetchSalesCountByDate(DateTime date);
        Task<int> FetchSalesCountByDateRange(DateTime startDate, DateTime endDate);
        Task<decimal> FetchSalesAmountByDate(DateTime date);
        Task<decimal> FetchSalesAmountByDateRange(DateTime startDate, DateTime endDate);
        Task<int> FetchTotalOrdersCount();
        Task<int> FetchOrdersCountByStatus(string status);
        Task<int> FetchTotalCustomersCount();
        Task<int> FetchTotalSuppliersCount();
        Task<int> FetchTotalBooksCount();
        Task<Book> FetchMostSellingBook();
    }
}
