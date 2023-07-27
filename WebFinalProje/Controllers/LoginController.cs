using DataAccessLayer.Data;
using EntityLayer.Siniflar;
using Microsoft.AspNetCore.Mvc;
using WebFinalProje.Utilities;

namespace WebFinalProje.Controllers
{
    public class LoginController : Controller
    {
        private readonly delalalaDBContext c;
        public LoginController(delalalaDBContext c)
        {
            this.c = c;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Kullanici p)
        {
            var bilgi = c.Kullanicis.FirstOrDefault(x => x.Email == p.Email && x.Sifre == p.Sifre);

            if (bilgi != null)
            {
                Session.SetUserSession(HttpContext, p.Email);
                if (p.Email == "admin@cafedelala.com")
                {
                    // Admin kullanıcı ise, Admin/Index sayfasına yönlendir
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    // Diğer kullanıcılar ise, Main/Index sayfasına yönlendir
                    return RedirectToAction("Index", "Main");
                }
            }
            else
            {
                // Kullanıcı bilgileri yanlış ise, hata mesajını görüntüle
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre";
                return View();
            }
        }
    }
}
