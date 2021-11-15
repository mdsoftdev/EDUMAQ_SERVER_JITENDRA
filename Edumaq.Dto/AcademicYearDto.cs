using System;
using Edumaq.DataAccess.Models;

namespace Edumaq.Dto
{
    public class AcademicYearDto
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsCurrentAcademicYear { get; set; }

        public AcademicYear ConvertToModel(AcademicYearDto academicyearDto)
        {
            AcademicYear academicYear = new AcademicYear();
            academicYear.Id = academicyearDto.id;
            academicYear.Name = academicyearDto.Name;
            academicYear.StartDate = DateTime.ParseExact(academicyearDto.StartDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            academicYear.EndDate = DateTime.ParseExact(academicyearDto.EndDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            academicYear.IsCurrentAcademicYear = Convert.ToBoolean(academicyearDto.IsCurrentAcademicYear);
            academicYear.CreatedDate = DateTime.Now;
            academicYear.CreatedBy = 0;
            academicYear.BranchId = 0;
            academicYear.ModifiedBy = 0;
            academicYear.ModifiedDate = DateTime.Now;

            return academicYear;
        }
    }
}
