using Edumaq.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edumaq.Dto
{
    public class GrnPurchaseItemDto
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public bool Status { get; set; }
        public long GrnPurchaseId { get; set; }
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public int Quatity { get; set; }
        public decimal Rate { get; set; }
        public decimal? Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }

        public GrnPurchaseItem ConvertToModel(GrnPurchaseItemDto grnPurchaseItemDto)
        {
            GrnPurchaseItem grnPurchaseItem = new GrnPurchaseItem();

            grnPurchaseItem.Id = grnPurchaseItemDto.Id;
            grnPurchaseItem.BranchId = grnPurchaseItemDto.BranchId;
            grnPurchaseItem.ItemId = grnPurchaseItemDto.ItemId;
            grnPurchaseItem.GrnPurchaseId = grnPurchaseItemDto.GrnPurchaseId;
            grnPurchaseItem.ItemName = grnPurchaseItemDto.ItemName;
            grnPurchaseItem.ItemCode = grnPurchaseItemDto.ItemCode;
            grnPurchaseItem.Quatity = grnPurchaseItemDto.Quatity;
            grnPurchaseItem.Rate = grnPurchaseItemDto.Rate;
            grnPurchaseItem.Discount = grnPurchaseItemDto.Discount != null ? grnPurchaseItemDto.Discount.Value : decimal.Zero ;
            grnPurchaseItem.Tax = grnPurchaseItemDto.Tax;
            grnPurchaseItem.Total = grnPurchaseItemDto.Total;

            grnPurchaseItem.CreatedDate = DateTime.Now;
            grnPurchaseItem.CreatedBy = 0;
            grnPurchaseItem.BranchId = 0;
            grnPurchaseItem.ModifiedBy = 0;
            grnPurchaseItem.ModifiedDate = DateTime.Now;
            grnPurchaseItem.Status = true;

            return grnPurchaseItem;
        }
    }
}
