using Edumaq.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edumaq.Dto
{
    public class PurchaseOrderDto
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public bool Status { get; set; }
        public long SupplierId { get; set; }
        public int QuotationNo { get; set; }
        public string QuotationDate { get; set; }
        public int PurchaseOrderNumber { get; set; }
        public string PurchaseOrderDate { get; set; }
        public string Remark { get; set; }
        public string InternalNote { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalPayable { get; set; }


        public PurchaseOrder ConvertToModel(PurchaseOrderDto purchaseOrderDto)
        {
            PurchaseOrder purchaseOrder = new PurchaseOrder();

            purchaseOrder.Id = purchaseOrderDto.Id;
            purchaseOrder.BranchId = purchaseOrderDto.BranchId;
            purchaseOrder.SupplierId = purchaseOrderDto.SupplierId;
            purchaseOrder.QuotationNo = purchaseOrderDto.QuotationNo;
            purchaseOrder.QuotationDate = DateTime.ParseExact(purchaseOrderDto.QuotationDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            purchaseOrder.PurchaseOrderNumber = purchaseOrderDto.PurchaseOrderNumber;
            purchaseOrder.PurchaseOrderDate = DateTime.ParseExact(purchaseOrderDto.PurchaseOrderDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            purchaseOrder.Remark = purchaseOrderDto.Remark;
            purchaseOrder.InternalNote = purchaseOrderDto.InternalNote;
            purchaseOrder.SubTotal = purchaseOrderDto.SubTotal;
            purchaseOrder.Discount = purchaseOrderDto.Discount;
            purchaseOrder.Tax = purchaseOrderDto.Tax;
            purchaseOrder.TotalPayable = purchaseOrderDto.TotalPayable;
            
            purchaseOrder.CreatedDate = DateTime.Now;
            purchaseOrder.CreatedBy = 0;
            purchaseOrder.BranchId = 0;
            purchaseOrder.ModifiedBy = 0;
            purchaseOrder.ModifiedDate = DateTime.Now;
            purchaseOrder.Status = true;

            return purchaseOrder;
        }
    }
}
