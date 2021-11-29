using System;
using Edumaq.DataAccess.Models;

namespace Edumaq.Dto
{
    public class SupplierDto
    {
        public long id { get; set; }
        public string SupplierName { get; set; }
        public long SupplierTypeId { get; set; }
        public string Code { get; set; }
        public string PanNo { get; set; }
        public string TanNo { get; set; }
        public string GstNo { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }
        public string Address { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string IfscCode { get; set; }
        public string BankName { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedDate { get; set; }
        public long DeletedBy { get; set; }

        public Supplier ConvertToModel(SupplierDto supplierDto)
        {
            Supplier supplier = new Supplier();
            supplier.Id = supplierDto.id;
            supplier.SupplierName = supplierDto.SupplierName;
            supplier.SupplierTypeId = supplierDto.SupplierTypeId;
            supplier.Code = supplierDto.Code;
            supplier.PanNo = supplierDto.PanNo;
            supplier.TanNo = supplierDto.TanNo;
            supplier.GstNo = supplierDto.GstNo;
            supplier.ContactNo = supplierDto.ContactNo;
            supplier.Email = supplierDto.Email;
            supplier.Website = supplierDto.Website;
            supplier.CountryId = supplierDto.CountryId;
            supplier.StateId = supplierDto.StateId;
            supplier.CityId = supplierDto.CityId;
            supplier.Address = supplierDto.Address;
            supplier.AccountName = supplierDto.AccountName;
            supplier.AccountNumber = supplierDto.AccountNumber;
            supplier.IfscCode = supplierDto.IfscCode;
            supplier.BankName = supplierDto.BankName;
            supplier.CreatedDate = DateTime.Now;
            supplier.CreatedBy = 0;
            supplier.BranchId = 0;
            supplier.ModifiedBy = 0;
            supplier.ModifiedDate = DateTime.Now;
            supplier.Status = supplierDto.Status;

            supplier.DeletedBy = 0;
            supplier.DeletedDate = DateTime.Now;

            //HARDCODED
            supplier.AcademicYearId = 2;

            return supplier;
        }
    }
}
