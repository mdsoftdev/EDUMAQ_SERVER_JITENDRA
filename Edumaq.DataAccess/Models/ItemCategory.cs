using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Edumaq.DataAccess.Models
{
    public class ItemCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("AcademicYear")]
        public long AcademicYearId { get; set; }

        [ForeignKey("ItemGroup")]
        public long ItemGroupId { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public long DeletedBy { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
