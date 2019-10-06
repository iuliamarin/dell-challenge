using DellChallenge.D2.Web.Models;
using DellChallenge.D2.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DellChallenge.D2.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _productService.GetAll();
            return View(model);
        }

        [HttpGet("modify")]
        public IActionResult Modify(ProductModel prod)
        {
           // var model = _productService.GetByID(id);
            return View(prod);
        }

        [HttpPost("update")]
        public IActionResult Update(ProductModel prod)
        {
             var model = _productService.Update(prod);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewProductModel newProduct)
        {
            _productService.Add(newProduct);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var isSuccess = _productService.Delete(id);
            return RedirectToAction("Index",isSuccess);
        }
    }
}