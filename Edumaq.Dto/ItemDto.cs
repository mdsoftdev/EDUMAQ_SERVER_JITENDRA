using Edumaq.DataAccess.Models;
using System;

namespace Edumaq.Dto
{
    public class ItemDto
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public bool Status { get; set; }
        public string ItemName { get; set; }
        public long ItemCategoryId { get; set; }
        public long ItemGroupId { get; set; }
        public string ItemCode { get; set; }
        public string SKU { get; set; }
        public long UnitId { get; set; }
        public string ItemType { get; set; }
        public int Size { get; set; }
        public long? ColorId { get; set; }
        public int OpeningStock { get; set; }
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
        public Item ConvertToModel(ItemDto itemDto)
        {
            Item item = new Item();

            item.Id = itemDto.Id;
            item.BranchId = itemDto.BranchId;
            item.ItemName = itemDto.ItemName;
            item.ItemCategoryId = itemDto.ItemCategoryId;
            item.ItemGroupId = itemDto.ItemGroupId;
            item.ItemCode = itemDto.ItemCode;
            item.SKU = itemDto.SKU;
            item.UnitId = itemDto.UnitId;
            item.ItemType = itemDto.ItemType;
            item.Size = itemDto.Size;
            item.ColorId = itemDto.ColorId;
            item.OpeningStock = itemDto.OpeningStock;
            item.TaxId = itemDto.TaxId;
            item.Cost = itemDto.Cost;
            item.SaleRate = itemDto.SaleRate;
            item.LowQtyAlert = itemDto.LowQtyAlert;
            item.IsBundledProduct = itemDto.IsBundledProduct;
            item.Description = itemDto.Description;
            item.Image = itemDto.Image;
            item.DeletedBy = itemDto.DeletedBy;
            item.DeletedDate = itemDto.DeletedDate;
            item.IsDeleted = itemDto.IsDeleted;

            item.CreatedDate = DateTime.Now;
            item.CreatedBy = 0;
            item.BranchId = 0;
            item.ModifiedBy = 0;
            item.ModifiedDate = DateTime.Now;
            item.Status = itemDto.Status;

            return item;
        }
    }
}
