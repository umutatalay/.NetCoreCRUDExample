using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoresubat.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }
    }
}
