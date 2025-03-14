using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Business.Interfaces
{
    public interface ISupplierOrderManagementService
    {
        List<Supplier> GetAllSuppliers();
        List<Book> GetLowStockBooks();
        void SaveSupplierOrder(SupplierOrder order);
        List<SupplierOrder> GetSupplierOrdersWithDetails();
        void UpdateBookStock(int bookId, int quantity);
        void UpdateOrderStatus(int orderID, string status);
    }
}
