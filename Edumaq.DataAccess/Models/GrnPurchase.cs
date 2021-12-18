using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Edumaq.DataAccess.Models
{
    public class GrnPurchase : BaseEntity
    {
        [ForeignKey("Supplier")]
        public long SupplierId { get; set; }

        public int PONumber { get; set; }
        public int SupplierInvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int GRNNumber { get; set; }
        public DateTime GRNDate { get; set; }
        public string Remark { get; set; }
        public string InternalNote { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal AdditionalCharges{ get; set; }
        public decimal TotalPayable { get; set; }

        public ICollection<GrnPurchaseItem> PurchaseOrderItem { get; set; }
    }
}
