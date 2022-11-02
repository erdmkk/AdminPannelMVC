using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new ProductRepository());
        //private readonly IProductRepository _productRepository;

        //public ProductController(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}


        //EKLE

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product p)
        {
            pm.ProductAdd(p);
            return RedirectToAction("Index");
        }

        //SİL

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (Context db = new Context())
            {
                var result = db.Products.FirstOrDefault(x => x.id == id);
                db.Products.Remove(result);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }       

        //GÜNCELLE

        [HttpGet]
        public IActionResult Update(int id)
        {
            using (Context db = new Context())
            {
                var result = db.Products.FirstOrDefault(o => o.id == id);
                return View(result);
            }
        }
        [HttpPost]
        public IActionResult Update(Product p)
        {
            var result = pm.ProductUpdate(p);
            return RedirectToAction("Index");
        }

        //INDEX

        public IActionResult Index()
        {
            var values = pm.GetProducts();
            return View(values);
        }
    }
}
