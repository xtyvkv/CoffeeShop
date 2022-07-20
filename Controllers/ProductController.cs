using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private CoffeeShopContext _CoffeeShopContext;

        public ProductController(ILogger<ProductController> logger, CoffeeShopContext newCoffeeShopContext)
        {
            _logger = logger;
            _CoffeeShopContext = newCoffeeShopContext;
        }
        public IActionResult Index()
        {
            var productList = _CoffeeShopContext.Product.ToArray();
            return View(productList);
            }

        public IActionResult Details()
            // pass parameter here
            // and put something in the view
        {
            return View();
        }
    }
}
