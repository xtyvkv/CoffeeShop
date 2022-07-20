using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CoffeeShopContext _CoffeeShopContext;

        public HomeController(ILogger<HomeController> logger, CoffeeShopContext newCoffeeShopContext)
        {
            _logger = logger;
            _CoffeeShopContext = newCoffeeShopContext;
        }

        public IActionResult Index()
        {
            // var productCount = _CoffeeShopContext.Product.Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}