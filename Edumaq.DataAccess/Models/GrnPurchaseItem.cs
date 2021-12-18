using System.ComponentModel.DataAnnotations.Schema;

namespace Edumaq.DataAccess.Models
{
    public class GrnPurchaseItem : BaseEntity
    {
        [ForeignKey("GrnPurchase")]
        public long GrnPurchaseId { get; set; }

        [ForeignKey("Item")]
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public int Quatity { get; set; }
        public decimal Rate { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }


    }
}
