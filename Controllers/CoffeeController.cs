using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class CoffeeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> results = DAL.GetAllProducts();
            return View(results);
        }

        public IActionResult product(int prod)
        {
            Product theprod = DAL.GetProduct(prod);
            return View(theprod);
        }
    }
}
