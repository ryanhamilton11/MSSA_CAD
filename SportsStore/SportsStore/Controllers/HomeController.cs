using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        //FIELDS & PROPERTIES
        private IProductRepository _repository;
        private int _pageSize = 4;



        //CONSTRUCTORS
        public HomeController (IProductRepository repository)//Dependency Injection(DI) OR Inversion of Control (IOC)
        {
            _repository = repository;
        }




        //METHODS
        //public IActionResult Index() => View(_repository.GetAllProducts());
        public IActionResult Index(int productPage = 1)
        {
            IQueryable<Product> allProducts = _repository.GetAllProducts();
            IQueryable<Product> someProducts = allProducts.OrderBy(p => p.ProductId)
                                                          .Skip((productPage - 1) * _pageSize)
                                                          .Take(_pageSize);
            ViewBag.ProductCount = allProducts.Count();

            return View(someProducts);
        }

        public IActionResult Categories()
        {
            IQueryable<string> categories = _repository.GetAllCategories();
            IQueryable<string> lengthCategories = categories.OrderBy(s => s.Length)
                                                            .ThenByDescending(s => s);
            return View(lengthCategories);
        }

        public IActionResult Details(int id)
        {
            Product product = _repository.GetProductById(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search(string productid)
        {
            IQueryable<Product> productsWithKeyword = _repository.GetProductsByKeyword(productid);
            return View(productsWithKeyword);
        }




        //CREATE
        [HttpGet]
        public IActionResult Add() => View();
       
        [HttpPost]
        public IActionResult Add(Product p)
        {
            _repository.Create(p);
            return RedirectToAction("Index");
        }





        //UPDATE
        [HttpGet]
        public IActionResult Update(int id)
        {
            Product product = _repository.GetProductById(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Product p)
        {
            Product updatedProduct = _repository.UpdateProduct(p);
            //return RedirectToAction("Index");
            return RedirectToAction("Details", new { productId = p.ProductId });
        }




        //DELETE
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product p = _repository.GetProductById(id);
            if (p != null)
            {
                return View(p);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete2(int id)
        {
            _repository.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
