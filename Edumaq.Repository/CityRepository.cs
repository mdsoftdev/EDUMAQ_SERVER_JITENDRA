using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Edumaq.Repository
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        private readonly EdumaqDBContext _dbContext;
        public CityRepository(EdumaqDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<City> GetCitiesByState(long id)
        {
            try
            {
                return _dbContext.Set<City>().Where(s => s.StateId == id).AsNoTracking();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        //public void RemoveCurrentAcademicYear()
        //{
        //    var academicyears = _dbContext.AcademicYears.ToList();
        //    academicyears.ForEach(a => a.IsCurrentAcademicYear = false);
        //    _dbContext.SaveChanges();
        //}

        //public bool IsCurrentAcademicYear()
        //{
        //    return _dbContext.AcademicYears.ToList().Any((a) => a.IsCurrentAcademicYear == true);
        //}
    }
}
