using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Edumaq.DataAccess.Models
{
    public class AcademicYear:BaseEntity
    {
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrentAcademicYear { get; set; }

        public ICollection<ItemGroup> ItemGroups { get; set; }
        public ICollection<ItemCategory> ItemCategories { get; set; }
        public ICollection<SupplierType> SupplierTypes { get; set; }
        public ICollection<Tax> Taxes { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
