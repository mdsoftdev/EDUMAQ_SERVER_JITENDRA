using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Edumaq.DataAccess.Models
{
    public class Supplier : BaseEntity
    {
        public string SupplierName { get; set; }

        [ForeignKey("SupplierType")]
        public long SupplierTypeId { get; set; }
        public string Code { get; set; }
        public string PanNo { get; set; }
        public string TanNo { get; set; }
        public string GstNo { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        [ForeignKey("Country")]
        public long CountryId { get; set; }

        [ForeignKey("State")]
        public long StateId { get; set; }

        [ForeignKey("City")]
        public long CityId { get; set; }
        public string Address { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string IfscCode { get; set; }
        public string BankName { get; set; }

        [ForeignKey("AcademicYear")]
        public long AcademicYearId { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public long DeletedBy { get; set; }
    }
}
