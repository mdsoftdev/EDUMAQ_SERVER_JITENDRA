
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Service.Interface
{
    public interface ICityService : IServiceBase<City>
    {
        //Task<Tax> InsertTax(Tax tax);
        ////bool IsCurrentAcademicyearExists();
        //Task<Tax> ModifyTax(long id, Tax tax);
        Task<IQueryable<City>> GetCitiesByState(long id);
    }
}
