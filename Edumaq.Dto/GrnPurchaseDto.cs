using Edumaq.DataAccess.Models;
using System;

namespace Edumaq.Dto
{
    public class GrnPurchaseDto
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public bool Status { get; set; }
        public long SupplierId { get; set; }
        public int PONumber { get; set; }
        public int SupplierInvoiceNo { get; set; }
        public string InvoiceDate { get; set; }
        public int GRNNumber { get; set; }
        public string GRNDate { get; set; }
        public string Remark { get; set; }
        public string InternalNote { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal AdditionalCharges { get; set; }
        public decimal TotalPayable { get; set; }


        public GrnPurchase ConvertToModel(GrnPurchaseDto grnPurchaseDto)
        {
            GrnPurchase grnPurchase = new GrnPurchase();

            grnPurchase.Id = grnPurchaseDto.Id;
            grnPurchase.BranchId = grnPurchaseDto.BranchId;
            grnPurchase.SupplierId = grnPurchaseDto.SupplierId;
            grnPurchase.PONumber = grnPurchaseDto.PONumber;
            grnPurchase.SupplierInvoiceNo = grnPurchaseDto.SupplierInvoiceNo;
            grnPurchase.InvoiceDate = DateTime.ParseExact(grnPurchaseDto.InvoiceDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            grnPurchase.GRNNumber = grnPurchaseDto.GRNNumber;
            grnPurchase.GRNDate = DateTime.ParseExact(grnPurchaseDto.GRNDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            grnPurchase.Remark = grnPurchaseDto.Remark;
            grnPurchase.InternalNote = grnPurchaseDto.InternalNote;
            grnPurchase.SubTotal = grnPurchaseDto.SubTotal;
            grnPurchase.Discount = grnPurchaseDto.Discount;
            grnPurchase.Tax = grnPurchaseDto.Tax;
            grnPurchase.AdditionalCharges = grnPurchaseDto.AdditionalCharges;
            grnPurchase.TotalPayable = grnPurchaseDto.TotalPayable;
            
            grnPurchase.CreatedDate = DateTime.Now;
            grnPurchase.CreatedBy = 0;
            grnPurchase.BranchId = 0;
            grnPurchase.ModifiedBy = 0;
            grnPurchase.ModifiedDate = DateTime.Now;
            grnPurchase.Status = true;

            return grnPurchase;
        }
    }
}
