using System;
using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Edumaq.Repository.Interfaces;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class TaxService : ServiceBase<Tax>, ITaxService
    {
        private readonly ITaxRepository _taxRepository;
        public TaxService(ITaxRepository repository) : base(repository)
        {
            _taxRepository = repository;
        }

        public async Task<Tax> InsertTax(Tax tax)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}
            return await _taxRepository.Create(tax);
        }

        //public bool IsCurrentAcademicyearExists()
        //{
        //    return _academicYearRepository.IsCurrentAcademicYear();
        //}

        public async Task<Tax> ModifyTax(long id, Tax tax)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}

            await _taxRepository.Update(id, tax);
            return tax;
        }
    }
}
