using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class SupplierOrder
    {
        public int SupplierOrderID { get; set; }
        public int SupplierID { get; set; } 
        public int BookID { get; set; } 
        public int Quantity { get; set; } 
        public DateTime OrderDate { get; set; } 
        public string Status { get; set; } 
        public Supplier Supplier { get; set; } 
        public Book Book { get; set; } 
    }
}
