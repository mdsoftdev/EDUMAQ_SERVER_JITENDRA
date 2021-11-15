using System;
using Edumaq.DataAccess.Models;

namespace Edumaq.Dto
{
    public class ItemCategoryDto
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long AcademicYearId { get; set; }
        public long ItemGroupId { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedDate { get; set; }
        public long DeletedBy { get; set; }

        public ItemCategory ConvertToModel(ItemCategoryDto itemCategoryDto)
        {
            ItemCategory itemCategory = new ItemCategory();
            itemCategory.Id = itemCategoryDto.id;
            itemCategory.Name = itemCategoryDto.Name;
            itemCategory.Description = itemCategoryDto.Description;
            //academicYear.StartDate = DateTime.ParseExact(academicyearDto.StartDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //academicYear.EndDate = DateTime.ParseExact(academicyearDto.EndDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //academicYear.IsCurrentAcademicYear = Convert.ToBoolean(academicyearDto.IsCurrentAcademicYear);
            itemCategory.CreatedDate = DateTime.Now;
            itemCategory.CreatedBy = 0;
            itemCategory.BranchId = 0;
            itemCategory.ModifiedBy = 0;
            itemCategory.ModifiedDate = DateTime.Now;
            itemCategory.Status = itemCategoryDto.Status;

            itemCategory.DeletedBy = 0;
            itemCategory.DeletedDate = DateTime.Now;

            //HARDCODED
            itemCategory.AcademicYearId = 2;

            itemCategory.ItemGroupId = itemCategoryDto.ItemGroupId;

            return itemCategory;
        }
    }
}
