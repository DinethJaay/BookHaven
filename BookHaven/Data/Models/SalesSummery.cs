using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class SalesSummery
    {
        public int CustomerTransactionId { get; set; }    
        public int CustomerId { get; set; }               
        public string? CustomerName { get; set; }          
        public decimal TotalAmount { get; set; }           
        public decimal DiscountAmount { get; set; }     
        public decimal FinalAmount { get; set; }          
        public DateTime TransactionDate { get; set; }     
    }
}
