using Edumaq.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edumaq.Dto
{
    public class PurchaseOrderItemDto
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public bool Status { get; set; }
        public long PurchaseOrderId { get; set; }
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public int Quatity { get; set; }
        public decimal Rate { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }

        public PurchaseOrderItem ConvertToModel(PurchaseOrderItemDto purchaseOrderItemDto)
        {
            PurchaseOrderItem purchaseOrderItem = new PurchaseOrderItem();

            purchaseOrderItem.Id = purchaseOrderItemDto.Id;
            purchaseOrderItem.BranchId = purchaseOrderItemDto.BranchId;
            purchaseOrderItem.ItemId = purchaseOrderItemDto.ItemId;
            purchaseOrderItem.PurchaseOrderId = purchaseOrderItemDto.PurchaseOrderId;
            purchaseOrderItem.ItemName = purchaseOrderItemDto.ItemName;
            purchaseOrderItem.ItemCode = purchaseOrderItemDto.ItemCode;
            purchaseOrderItem.Quatity = purchaseOrderItemDto.Quatity;
            purchaseOrderItem.Rate = purchaseOrderItemDto.Rate;
            purchaseOrderItem.Discount = purchaseOrderItemDto.Discount;
            purchaseOrderItem.Tax = purchaseOrderItemDto.Tax;
            purchaseOrderItem.Total = purchaseOrderItemDto.Total;

            purchaseOrderItem.CreatedDate = DateTime.Now;
            purchaseOrderItem.CreatedBy = 0;
            purchaseOrderItem.BranchId = 0;
            purchaseOrderItem.ModifiedBy = 0;
            purchaseOrderItem.ModifiedDate = DateTime.Now;
            purchaseOrderItem.Status = true;

            return purchaseOrderItem;
        }
    }
}
