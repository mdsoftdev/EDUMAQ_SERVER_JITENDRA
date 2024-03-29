﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Edumaq.DataAccess.Models
{
    public class Item : BaseEntity
    {
        public string ItemName { get; set; }

        [ForeignKey("ItemCategory")]
        public long ItemCategoryId { get; set; }

        [ForeignKey("ItemGroup")]
        public long ItemGroupId { get; set; }

        public string ItemCode { get; set; }
        public string SKU { get; set; }

        [ForeignKey("Unit")]
        public long UnitId { get; set; }

        public string ItemType { get; set; }
        public int Size { get; set; }

        [ForeignKey("Color")]
        public long? ColorId { get; set; }
        public int OpeningStock { get; set; }

        [ForeignKey("Tax")]
        public long TaxId { get; set; }
        public int Cost { get; set; }
        public int SaleRate { get; set; }
        public int LowQtyAlert { get; set; }
        public bool IsBundledProduct { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public long DeletedBy { get; set; }

        [InverseProperty("BundleInv")]
        public virtual ICollection<ProductBundle> BundleRef { get; set; }
        [InverseProperty("ItemInv")]
        public virtual ICollection<ProductBundle> ItemRef { get; set; }
        public ICollection<PurchaseOrderItem> PurchaseOrderItem { get; set; }
        public ICollection<GrnPurchaseItem> GrnPurchaseItem { get; set; }
    }
}
