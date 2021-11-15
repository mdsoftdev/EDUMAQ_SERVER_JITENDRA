using System;
using Edumaq.DataAccess.Models;

namespace Edumaq.Dto
{
    public class SupplierTypeDto
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long AcademicYearId { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedDate { get; set; }
        public long DeletedBy { get; set; }

        public SupplierType ConvertToModel(SupplierTypeDto supplierTypeDto)
        {
            SupplierType supplierType = new SupplierType();
            supplierType.Id = supplierTypeDto.id;
            supplierType.Name = supplierTypeDto.Name;
            supplierType.Description = supplierTypeDto.Description;
            //academicYear.StartDate = DateTime.ParseExact(academicyearDto.StartDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //academicYear.EndDate = DateTime.ParseExact(academicyearDto.EndDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //academicYear.IsCurrentAcademicYear = Convert.ToBoolean(academicyearDto.IsCurrentAcademicYear);
            supplierType.CreatedDate = DateTime.Now;
            supplierType.CreatedBy = 0;
            supplierType.BranchId = 0;
            supplierType.ModifiedBy = 0;
            supplierType.ModifiedDate = DateTime.Now;
            supplierType.Status = supplierTypeDto.Status;

            supplierType.DeletedBy = 0;
            supplierType.DeletedDate = DateTime.Now;

            //HARDCODED
            supplierType.AcademicYearId = 2;

            return supplierType;
        }
    }
}
