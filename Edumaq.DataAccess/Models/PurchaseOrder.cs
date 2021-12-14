using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Edumaq.DataAccess.Models
{
    public class PurchaseOrder : BaseEntity
    {
        [ForeignKey("Supplier")]
        public string SupplierId { get; set; }

        public int QuotationNo { get; set; }
        public DateTime QuotationDate { get; set; }
        public int PurchaseOrderNumber { get; set; }
        public DateTime PurchaseOrderDate { get; set; }
        public string Remark { get; set; }
        public string InternalNote { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalPayable { get; set; }

        public ICollection<PurchaseOrderItem> PurchaseOrderItem { get; set; }
    }
}
