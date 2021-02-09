using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoresubat.Interfaces;
using NetCoresubat.Repositories;

namespace NetCoresubat.Controllers
{
    public class CategoriesController : Controller
    {
        ICategoriesRepository _CategoryRepository;

        public CategoriesController(ICategoriesRepository CategoryRepository)
        {

            _CategoryRepository = CategoryRepository;
        }
        public IActionResult Index()
        {

            return View(_CategoryRepository.GetAll());
        }
    }
}
