using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.DashboardManagementRepository;

namespace BookHaven.Business.Services
{
    public class DashboardManagementService : IDashboardManagementService
    {
        private readonly IDashboardRepository _dashboardRepository;
        public DashboardManagementService(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }
        public async Task<int> GetDailySalesCount()
        {
            return await _dashboardRepository.FetchSalesCountByDate(DateTime.Now.Date);
        }

        public async Task<int> GetWeeklySalesCount()
        {
            var startOfWeek = DateTime.Now.AddDays(-((int)DateTime.Now.DayOfWeek));
            return await _dashboardRepository.FetchSalesCountByDateRange(startOfWeek, DateTime.Now);
        }

        public async Task<int> GetMonthlySalesCount()
        {
            var startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            return await _dashboardRepository.FetchSalesCountByDateRange(startOfMonth, DateTime.Now);
        }
        public async Task<decimal> GetDailySalesAmount()
        {
            return await _dashboardRepository.FetchSalesAmountByDate(DateTime.Now.Date);
        }

        public async Task<decimal> GetWeeklySalesAmount()
        {
            var startOfWeek = DateTime.Now.AddDays(-((int)DateTime.Now.DayOfWeek));
            return await _dashboardRepository.FetchSalesAmountByDateRange(startOfWeek, DateTime.Now);
        }

        public async Task<decimal> GetMonthlySalesAmount()
        {
            var startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            return await _dashboardRepository.FetchSalesAmountByDateRange(startOfMonth, DateTime.Now);
        }
        public async Task<int> GetTotalOrdersCount()
        {
            return await _dashboardRepository.FetchTotalOrdersCount();
        }

        public async Task<int> GetPendingOrdersCount()
        {
            return await _dashboardRepository.FetchOrdersCountByStatus("Pending");
        }

        public async Task<int> GetCompletedOrdersCount()
        {
            return await _dashboardRepository.FetchOrdersCountByStatus("Completed");
        }
        public async Task<int> GetTotalCustomersCount()
        {
            return await _dashboardRepository.FetchTotalCustomersCount();
        }

        public async Task<int> GetTotalSuppliersCount()
        {
            return await _dashboardRepository.FetchTotalSuppliersCount();
        }

        public async Task<int> GetTotalBooksCount()
        {
            return await _dashboardRepository.FetchTotalBooksCount();
        }

        public async Task<Book> GetMostSellingBook()
        {
            return await _dashboardRepository.FetchMostSellingBook();
        }
    }
}
