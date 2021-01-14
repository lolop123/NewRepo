using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;

namespace WebApplication1.Data.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
            private readonly ICarsCategory _allCategories;
    }
}
