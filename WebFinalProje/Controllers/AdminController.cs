using DataAccessLayer.Data;
using DataAccessLayer.Services;
using EntityLayer.Siniflar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebFinalProje.Controllers
{
    public class AdminController : Controller
    {
        readonly delalalaDBContext c = new delalalaDBContext();
        private readonly IIcecekiService icecekiService;
        private readonly ITatliService tatliService;
        private readonly IKategoriService kategoriService;
        public AdminController(IIcecekiService icecekiService,
                               ITatliService tatliService,
                               IKategoriService kategoriService,
                               delalalaDBContext c)
        {
            this.icecekiService = icecekiService;
            this.tatliService = tatliService;
            this.kategoriService = kategoriService;
            this.c = c;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TatliGoruntule()
        {
            var degerler = tatliService.TatliListele();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult TatliEkle()
        {
            ViewBag.Kategoriler = kategoriService.KategoriListele();
            return View();
        }

        [HttpPost]
        public IActionResult TatliEkle(Tatlilar t)
        {
            tatliService.TatliEkle(t);
            return RedirectToAction("TatliGoruntule", "Admin");

            var kategori = kategoriService.KategoriListele();
            ViewBag.Kategoriler = new SelectList(kategori, "Id", "KategoriAd");
            return View(t);
        }

        public ActionResult TatliSil(int id)
        {
            tatliService.TatliSil(id);
            return RedirectToAction("TatliGoruntule","Admin");
        }

        public ActionResult TatliGetir(int id)
        {
            var tatli = c.Tatlilars.Find(id);
            if (tatli == null)
            {
                return NotFound();
            }

            ViewBag.Kategoriler = c.Kategoris.ToList();
            return View(tatli);
        }

        public ActionResult TatliGuncelle(Tatlilar t)
        {
            tatliService.TatliGuncelle(t);
            return RedirectToAction("TatliGoruntule","Admin");
        }

        public IActionResult IcecekGoruntule()
        {
            var degerler = icecekiService.IcecekListele();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult IcecekEkle()
        {
            ViewBag.Kategoriler = kategoriService.KategoriListele();
            return View();
        }

        [HttpPost]
        public IActionResult IcecekEkle(Icecekler i)
        {
            icecekiService.IcecekEkle(i);
            return RedirectToAction("IcecekGoruntule", "Admin");

            var kategori = kategoriService.KategoriListele();
            ViewBag.Kategoriler = new SelectList(kategori, "Id", "KategoriAd");
            return View(i);
        }

        public ActionResult IcecekSil(int id)
        {
            icecekiService.IcecekSil(id);
            return RedirectToAction("IcecekGoruntule", "Admin");
        }

        public ActionResult IcecekGetir(int id)
        {
            var icecek = c.Iceceklers.Find(id);
            if (icecek == null)
            {
                return NotFound();
            }

            ViewBag.Kategoriler = c.Kategoris.ToList();
            return View(icecek);
        }

        public ActionResult IcecekGuncelle(Icecekler i)
        {
            icecekiService.IcecekGuncelle(i);
            return RedirectToAction("IcecekGoruntule", "Admin");
        }

    }
}
