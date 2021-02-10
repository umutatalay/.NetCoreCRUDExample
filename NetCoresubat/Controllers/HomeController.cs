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
        public IActionResult AddProducts(AddProductsModel p)
        {
            products product = new products();
            product.productsName = p.ProductName;
            product.productsPrice = p.ProductPrice;
            _productRepository.Add(product);
            return View();
        }
        [HttpGet]
        public IActionResult AddProducts()
        {
            return View();
        }

        public IActionResult RemoveProduct(int id)
        {
            _productRepository.Remove(new products { productsID = id });
            return RedirectToAction("Index");
        }

        public IActionResult UpdateProduct(int id)
        {
            var p = _productRepository.GetByID(id);
            UpdateProductsModel model = new UpdateProductsModel {
                ProductName = p.productsName,
                ProductPrice = p.productsPrice,
                ProductID = p.productsID,

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductsModel p)
        {
            var currentproduct = _productRepository.GetByID(p.ProductID);
            products product = new products();

            currentproduct.productsName = p.ProductName;
            currentproduct.productsPrice = p.ProductPrice;
            _productRepository.Update(product);
            return View();
        }
    }
}
