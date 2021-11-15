using System;
using Edumaq.DataAccess.Models;

namespace Edumaq.Dto
{
    public class ItemGroupDto
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long AcademicYearId { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedDate { get; set; }
        public long DeletedBy { get; set; }

        public ItemGroup ConvertToModel(ItemGroupDto itemGroupDto)
        {
            ItemGroup itemGroup = new ItemGroup();
            itemGroup.Id = itemGroupDto.id;
            itemGroup.Name = itemGroupDto.Name;
            itemGroup.Description = itemGroupDto.Description;
            //academicYear.StartDate = DateTime.ParseExact(academicyearDto.StartDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //academicYear.EndDate = DateTime.ParseExact(academicyearDto.EndDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //academicYear.IsCurrentAcademicYear = Convert.ToBoolean(academicyearDto.IsCurrentAcademicYear);
            itemGroup.CreatedDate = DateTime.Now;
            itemGroup.CreatedBy = 0;
            itemGroup.BranchId = 0;
            itemGroup.ModifiedBy = 0;
            itemGroup.ModifiedDate = DateTime.Now;
            itemGroup.Status = itemGroupDto.Status;

            itemGroup.DeletedBy = 0;
            itemGroup.DeletedDate = DateTime.Now;

            //HARDCODED
            itemGroup.AcademicYearId = 2;

            return itemGroup;
        }
    }
}
