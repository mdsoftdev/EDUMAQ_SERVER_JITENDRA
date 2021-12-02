using System;
using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Edumaq.Repository.Interfaces;
using System.Threading.Tasks;
using System.Linq;

namespace Edumaq.Service
{
    public class CityService : ServiceBase<City>, ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository repository) : base(repository)
        {
            _cityRepository = repository;
        }
        public async Task<IQueryable<City>> GetCitiesByState(long id)
        {
            return _cityRepository.GetCitiesByState(id);
        }
        //public async Task<Tax> InsertTax(Tax tax)
        //{
        //    //if (academicYear.IsCurrentAcademicYear)
        //    //{
        //    //    _academicYearRepository.RemoveCurrentAcademicYear();
        //    //}
        //    return await _taxRepository.Create(tax);
        //}

        //public bool IsCurrentAcademicyearExists()
        //{
        //    return _academicYearRepository.IsCurrentAcademicYear();
        //}

        //public async Task<Tax> ModifyTax(long id, Tax tax)
        //{
        //    //if (academicYear.IsCurrentAcademicYear)
        //    //{
        //    //    _academicYearRepository.RemoveCurrentAcademicYear();
        //    //}

        //    await _taxRepository.Update(id, tax);
        //    return tax;
        //}
    }
}
