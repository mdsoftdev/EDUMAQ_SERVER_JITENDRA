using System.Collections.Generic;

namespace Edumaq.DataAccess.Models
{
    public class Color : BaseEntity
    {
        public string Value { get; set; }
        public string Description { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
