using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoresubat.Interfaces;

namespace NetCoresubat.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository _productRepository;
        ICategoriesRepository _CategoryRepository;
        public HomeController(IProductRepository  productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
           
            return View(_productRepository.GetAll());

        }

        public IActionResult CetegoriesPage()
        {
            return View(_CategoryRepository.GetAll());
        }

        public IActionResult GetProductsByID(int id)
        {
            return View(_productRepository.GetByID(id));
        }


    }
}
