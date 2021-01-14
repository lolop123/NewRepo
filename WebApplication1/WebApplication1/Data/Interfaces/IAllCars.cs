using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Cars> cars { get; }
        IEnumerable<Cars> getFavCars { get; set; }
        Cars getObjectCar(int carid);
    }
}
