using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Mox
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> allCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {    catecoryname = "электромбили", desc = "современный вид транспорта"},
                    new Category{catecoryname = "классика", desc = "двигатель внутреннего сгорания" }
                };
            }
        }
    }
}
