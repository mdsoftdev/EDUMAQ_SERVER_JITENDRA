using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Service.Interface
{
    public interface IAcademicYearService:IServiceBase<AcademicYear>
    {
        void InsertAcademicYear(AcademicYear academicYear);
        bool IsCurrentAcademicyearExists();
        AcademicYear ModifyAcademicYear(long id, AcademicYear academicYear);
    }
}
