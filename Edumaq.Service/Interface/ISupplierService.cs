using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Service.Interface
{
    public interface ISupplierService : IServiceBase<Supplier>
    {
        Task<Supplier> InsertSupplier(Supplier supplier);
        //bool IsCurrentAcademicyearExists();
        Task<Supplier> ModifySupplier(long id, Supplier supplier);
    }
}
