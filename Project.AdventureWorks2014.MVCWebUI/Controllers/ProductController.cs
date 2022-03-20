using Microsoft.AspNetCore.Mvc;
using Project.AdventureWorks2014.Business.Abstract;
using Project.AdventureWorks2014.MVCWebUI.Models;
using System.Diagnostics;

namespace Project.AdventureWorks2014.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
		private IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var product = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = product,
            };
            return View(model);
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