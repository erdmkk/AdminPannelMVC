using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CustomerPresent.Controllers
{
    public class ProductController : Controller
    {
        Context c = new Context();
        ProductManager pm = new ProductManager(new ProductRepository());
 
        public IActionResult Index()
        {
            return View();
        }

        //Listeleme
        public IActionResult Urunler()
        {
            var value = pm.GetProducts();
            return View(value);
        }

    }
}
