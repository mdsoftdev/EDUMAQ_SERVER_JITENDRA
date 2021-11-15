using System;
using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Edumaq.Repository.Interfaces;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class SupplierTypeService : ServiceBase<SupplierType>, ISupplierTypeService
    {
        private readonly ISupplierTypeRepository _supplierTypeRepository;
        public SupplierTypeService(ISupplierTypeRepository repository) : base(repository)
        {
            _supplierTypeRepository = repository;
        }

        public async Task<SupplierType> InsertSupplierType(SupplierType supplierType)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}
            return await _supplierTypeRepository.Create(supplierType);
        }

        //public bool IsCurrentAcademicyearExists()
        //{
        //    return _academicYearRepository.IsCurrentAcademicYear();
        //}

        public async Task<SupplierType> ModifySupplierType(long id, SupplierType supplierType)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}

            await _supplierTypeRepository.Update(id, supplierType);
            return supplierType;
        }
    }
}
