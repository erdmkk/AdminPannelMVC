using DataAccessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GirisYap(User p)
        {
            var bilgiler = c.Users.FirstOrDefault(x => x.email == p.email && x.password == p.password);

            if (bilgiler != null)
            {
                return RedirectToAction("Index", "Product");
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
