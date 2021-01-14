    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Cars
    {
        public int id { get; set; }
        public string name { get; set; }
        public string  shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool IsFavorite { get; set; }
        public bool aviable { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
