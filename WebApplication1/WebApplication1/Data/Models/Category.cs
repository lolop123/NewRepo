using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string catecoryname { get; set; }
        public string desc { get; set; }
        public List<Cars> cars { get; set; }
    }
}
