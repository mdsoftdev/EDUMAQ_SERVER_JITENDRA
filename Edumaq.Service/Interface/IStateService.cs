using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Service.Interface
{
    public interface IStateService : IServiceBase<State>
    {
        //Task<Tax> InsertTax(Tax tax);
        ////bool IsCurrentAcademicyearExists();
        Task<IQueryable<State>> GetStatesByCountry(long id);
    }
}
