using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Service.Interface
{
    public interface ISupplierTypeService : IServiceBase<SupplierType>
    {
        Task<SupplierType> InsertSupplierType(SupplierType supplierType);
        //bool IsCurrentAcademicyearExists();
        Task<SupplierType> ModifySupplierType(long id, SupplierType supplierType);
    }
}
