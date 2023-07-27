using DataAccessLayer.Data;
using EntityLayer.Siniflar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebFinalProje.Controllers
{
    public class RegisterController : Controller
    {
        private readonly delalalaDBContext c;
        public RegisterController(delalalaDBContext c)
        {
            this.c = c;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var kullanici = c.Kullanicis.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Kullanici p)
        {
            try
            {
                c.Kullanicis.Add(p);
                c.SaveChanges();
                return RedirectToAction("Index", "Login");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return View(p);
            }
        }
    }
}
