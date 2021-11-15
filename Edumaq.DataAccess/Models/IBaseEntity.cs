using System;
using System.Collections.Generic;
using System.Text;

namespace Edumaq.DataAccess.Models
{
    public interface IBaseEntity
    {
        long Id {get; set;}
        long BranchId { get; set; }
        bool Status { get; set; }
        DateTime CreatedDate { get; set; }
        long CreatedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        long ModifiedBy { get; set; }
    }
}
