using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Edumaq.DataAccess.Models
{
    public class State : BaseEntity
    {
        public string StateName { get; set; }

        [ForeignKey("Country")]
        public long CountryId { get; set; }

        public ICollection<City> Cities { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
