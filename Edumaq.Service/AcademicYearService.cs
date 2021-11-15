using System;
using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Edumaq.Repository.Interfaces;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class AcademicYearService:ServiceBase<AcademicYear>, IAcademicYearService
    {
        private readonly IAcademicYearRepository _academicYearRepository;
        public AcademicYearService(IAcademicYearRepository repository) : base(repository)
        {
            _academicYearRepository = repository;
        }

        public void InsertAcademicYear(AcademicYear academicYear)
        {
            if (academicYear.IsCurrentAcademicYear)
            {
                _academicYearRepository.RemoveCurrentAcademicYear();
            }
            _academicYearRepository.Create(academicYear);
        }

        public bool IsCurrentAcademicyearExists()
        {
            return _academicYearRepository.IsCurrentAcademicYear();
        }

        public AcademicYear ModifyAcademicYear(long id, AcademicYear academicYear)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}

            _academicYearRepository.Update(id, academicYear);
            return academicYear;
        }
    }
}
