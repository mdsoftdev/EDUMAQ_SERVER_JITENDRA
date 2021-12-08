using System.ComponentModel.DataAnnotations.Schema;

namespace Edumaq.DataAccess.Models
{
    public class ProductBundle : BaseEntity
    {
        public long BundleId { get; set; }
        public long ItemId { get; set; }
        public string Code { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("BundleId")]
        public virtual Item BundleInv { get; set; }

        [ForeignKey("ItemId")]
        public virtual Item ItemInv { get; set; }
    }
}
