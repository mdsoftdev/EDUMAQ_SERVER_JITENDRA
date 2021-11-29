using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Repository.Interfaces
{
    public interface IStateRepository : IRepositoryBase<State>
    {
        //public void RemoveCurrentAcademicYear();
        //public bool IsCurrentAcademicYear();
        public IQueryable<State> GetStatesByCountry(long id);
    }
}
