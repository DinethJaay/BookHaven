using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Business.Interfaces
{
    public interface IDashboardManagementService
    {
        Task<int> GetDailySalesCount();
        Task<int> GetWeeklySalesCount();
        Task<int> GetMonthlySalesCount();
        Task<decimal> GetDailySalesAmount();
        Task<decimal> GetWeeklySalesAmount();
        Task<decimal> GetMonthlySalesAmount();
        Task<int> GetTotalOrdersCount();
        Task<int> GetPendingOrdersCount();
        Task<int> GetCompletedOrdersCount();
        Task<int> GetTotalCustomersCount();
        Task<int> GetTotalSuppliersCount();
        Task<int> GetTotalBooksCount();
        Task<Book> GetMostSellingBook();
    }
}
