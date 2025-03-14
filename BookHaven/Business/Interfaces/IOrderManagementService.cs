using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Business.Interfaces
{
    public interface IOrderManagementService
    {
        List<Customer> GetCustomerByPhone(string phoneNumber);
        List<Book> GetBookByTitle(string title);
        void SaveOrder(Order order);
        List<Order> GetAllOrders(); 
        Order GetOrderById(int orderId);  
        bool UpdateOrderStatus(Order order);
        bool UpdateBookStock(int bookId, int quantity);
    }
}
