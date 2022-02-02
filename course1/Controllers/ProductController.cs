using course1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using course1.Services;

namespace course1.Controllers
{
    public class Product : Controller
    {
        static List<ProductModel> product = new List<ProductModel>();
        public IActionResult Index()
        {
            // The lines below are hard coded list items. This method is only to be used to test the site. The product model must be imported to make this work
            //List<ProductModel> productList = new List<ProductModel>();

            //productList.Add(new ProductModel { ID = 1, Name = "Mouse Pad",  Price = 5.99m, Description = "A Mouse Pad for a computer"});
            //productList.Add(new ProductModel { ID = 2, Name = "Web Cam", Price = 45.50m, Description = "Desktop camrea" });
            //productList.Add(new ProductModel { ID = 3, Name = "4TB Hard Drive", Price = 130.00m, Description = "Removable Hard Drive" });
            //productList.Add(new ProductModel { ID = 4, Name = "Wireless Mouse", Price = 15.99m, Description = "Cordless Mouse for laptops" });


            // must place the list inside the View to have it usable 
            //HardCodedSampleRepository hardCodedSampleRepository = new HardCodedSampleRepository();
            //return View(hardCodedSampleRepository.GetAllProducts());

            ProductsDAO products = new ProductsDAO();

            return View(products.GetAllProducts());
        }

        public IActionResult SearchResults(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productList = products.SearchProducts(searchTerm); 
            return View("index", productList);
        }

        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult CreateForm()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("ShowEdit", foundProduct);
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return View("Index", products.GetAllProducts());
        }

        public IActionResult Delete(int Id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel product = products.GetProductById(Id);
            products.Delete(product);
            return View("Index", products.GetAllProducts());
        }

        public IActionResult Details(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View(foundProduct);
        }

        public IActionResult Message() 
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
