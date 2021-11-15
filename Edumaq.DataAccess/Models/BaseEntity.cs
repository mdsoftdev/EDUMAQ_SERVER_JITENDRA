using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Edumaq.DataAccess.Models
{
    public class BaseEntity:IBaseEntity
    {
        [Key]
        public long Id { get; set; }
        public long BranchId { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long ModifiedBy { get; set; }
    }
}
