using System;
using Edumaq.DataAccess.Models;

namespace Edumaq.Dto
{
    public class TaxDto
    {
        public long id { get; set; }
        public string TaxName { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public string RateUnit { get; set; }
        public long AcademicYearId { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedDate { get; set; }
        public long DeletedBy { get; set; }

        public Tax ConvertToModel(TaxDto taxDto)
        {
            Tax tax = new Tax();
            tax.Id = taxDto.id;
            tax.TaxName = taxDto.TaxName;
            tax.Description = taxDto.Description;
            tax.Rate = taxDto.Rate;
            tax.RateUnit = taxDto.RateUnit;
            //academicYear.StartDate = DateTime.ParseExact(academicyearDto.StartDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //academicYear.EndDate = DateTime.ParseExact(academicyearDto.EndDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //academicYear.IsCurrentAcademicYear = Convert.ToBoolean(academicyearDto.IsCurrentAcademicYear);
            tax.CreatedDate = DateTime.Now;
            tax.CreatedBy = 0;
            tax.BranchId = 0;
            tax.ModifiedBy = 0;
            tax.ModifiedDate = DateTime.Now;
            tax.Status = taxDto.Status;

            tax.DeletedBy = 0;
            tax.DeletedDate = DateTime.Now;

            //HARDCODED
            tax.AcademicYearId = 2;

            return tax;
        }
    }
}
