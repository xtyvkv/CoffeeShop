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
        public IActionResult Details(int Id)
        {
            Product product = null;
            foreach (var currProduct in _CoffeeShopContext.Product.ToArray())
            {
                if (currProduct.Id == Id)
                {
                    product = currProduct;
                    break;
                }
            }
            return View(product);
        }
        // Display the form
        public IActionResult Create()
        {
            return View();
        }
        // Process the form results
        // Must specify POST!!
        [HttpPost]
        public IActionResult CreateSubmit(Product newProduct)
        {
            _CoffeeShopContext.Product.Add(newProduct);
            _CoffeeShopContext.SaveChanges();
            return Details(newProduct.Id);
        }
    }
}
