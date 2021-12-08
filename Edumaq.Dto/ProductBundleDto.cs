using Edumaq.DataAccess.Models;
using System;

namespace Edumaq.Dto
{
    public class ProductBundleDto
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public bool Status { get; set; }
        public string Code { get; set; }
        public int Quantity { get; set; }
        public long BundleId { get; set; }
        public long ItemId { get; set; }
        

        public ProductBundle ConvertToModel(ProductBundleDto dto)
        {
            ProductBundle productBundle = new ProductBundle();

            productBundle.Id = dto.Id;
            productBundle.BranchId = dto.BranchId;
            productBundle.BundleId = dto.BundleId;
            productBundle.ItemId = dto.ItemId;
            productBundle.Code = dto.Code;
            productBundle.Quantity = dto.Quantity;

            productBundle.CreatedDate = DateTime.Now;
            productBundle.CreatedBy = 0;
            productBundle.BranchId = 0;
            productBundle.ModifiedBy = 0;
            productBundle.ModifiedDate = DateTime.Now;
            productBundle.Status = true;

            return productBundle;
        }
    }
}
