using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoresubat.Entities;
using NetCoresubat.Interfaces;
using NetCoresubat.Models;

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

        [HttpPost]
        public IActionResult AddProductsTest(AddProductsModel p)
        {
            products product = new products();
            product.productsName = p.ProductName;
            product.productsPrice = p.ProductPrice;
            _productRepository.Add(product);


            return RedirectToAction("Index", "Home");

        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult RemoveProduct(int id)
        {
            _productRepository.Remove(new products { productsID = id });
            return RedirectToAction("Index");
        }


    }
}
