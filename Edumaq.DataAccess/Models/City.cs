using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Edumaq.DataAccess.Models
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }

        [ForeignKey("State")]
        public long StateId { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
