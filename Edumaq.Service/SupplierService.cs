using System;
using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Edumaq.Repository.Interfaces;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class SupplierService : ServiceBase<Supplier>, ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierService(ISupplierRepository repository) : base(repository)
        {
            _supplierRepository = repository;
        }

        public async Task<Supplier> InsertSupplier(Supplier supplier)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}
            return await _supplierRepository.Create(supplier);
        }

        //public bool IsCurrentAcademicyearExists()
        //{
        //    return _academicYearRepository.IsCurrentAcademicYear();
        //}

        public async Task<Supplier> ModifySupplier(long id, Supplier supplier)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}

            await _supplierRepository.Update(id, supplier);
            return supplier;
        }
    }
}
