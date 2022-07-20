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
            var newModel = new Models.Product();
            var productNameList = new List<string>();
            foreach (var currProduct in _CoffeeShopContext.Product)
                productNameList.Add($"{currProduct.Name}");
            return View(productNameList);
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
