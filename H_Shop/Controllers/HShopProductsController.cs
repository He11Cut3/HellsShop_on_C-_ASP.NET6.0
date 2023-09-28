using H_Shop.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace H_Shop.Controllers
{
    public class HShopProductsController : Controller
    {
        private readonly DataContext _context;

        public HShopProductsController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var prod = _context.HShopProducts.ToList();

            return View(prod);
        }
    }
}
