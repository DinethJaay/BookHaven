using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Business.Interfaces
{
    public interface ISupplierManagementService
    {
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        List<Supplier> GetAllSuppliers();
        Supplier GetSupplierByName(string supplierName);
        void DeactivateSupplier(int supplierId); 
        List<Supplier> GetActiveSuppliers();
    }
}
