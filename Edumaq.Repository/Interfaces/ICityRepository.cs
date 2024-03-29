﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Repository.Interfaces
{
    public interface ICityRepository : IRepositoryBase<City>
    {
        //public void RemoveCurrentAcademicYear();
        //public bool IsCurrentAcademicYear();
        public IQueryable<City> GetCitiesByState(long id);
    }
}
