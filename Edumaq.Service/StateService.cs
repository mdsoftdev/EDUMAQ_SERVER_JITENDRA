using System;
using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Edumaq.Repository.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Edumaq.Service
{
    public class StateService : ServiceBase<State>, IStateService
    {
        private readonly IStateRepository _stateRepository;
        public StateService(IStateRepository repository) : base(repository)
        {
            _stateRepository = repository;
        }
        public async Task<IQueryable<State>> GetStatesByCountry(long id) {
            return _stateRepository.GetStatesByCountry(id);
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
