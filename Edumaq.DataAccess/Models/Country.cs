using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Edumaq.DataAccess.Models
{
    public class Country : BaseEntity
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public ICollection<State> States { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
