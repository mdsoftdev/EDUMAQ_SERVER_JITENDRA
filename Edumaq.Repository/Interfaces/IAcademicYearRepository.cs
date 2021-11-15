using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Repository.Interfaces
{
    public interface IAcademicYearRepository : IRepositoryBase<AcademicYear>
    {
       public void RemoveCurrentAcademicYear();
       public bool IsCurrentAcademicYear();
    }
}
