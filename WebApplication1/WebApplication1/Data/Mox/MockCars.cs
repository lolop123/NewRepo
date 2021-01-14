using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Mox
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _caregorycars = new MockCategory();
        public IEnumerable<Cars> cars {
            get
            {
                return new List<Cars> { new Cars { name = "Tesla", shortDesc = "", longDesc = "", img = "", price = 45000, IsFavorite = true, aviable = true, Category = _caregorycars.allCategories.First() } };
            }
            
                
                }
        public IEnumerable<Cars> getFavCars { get ; set; }

        public Cars getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
