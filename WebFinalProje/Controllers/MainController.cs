using DataAccessLayer.Data;
using DataAccessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using WebFinalProje.Models.ViewModel;

namespace WebFinalProje.Controllers
{
    public class MainController : Controller
    {
        private readonly IIcecekiService icecekiService;
        private readonly ITatliService tatliService;
        private readonly IKategoriService kategoriService;
        public MainController(IIcecekiService icecekiService,
                               ITatliService tatliService,
                               IKategoriService kategoriService)
        {
            this.icecekiService = icecekiService;
            this.tatliService = tatliService;
            this.kategoriService = kategoriService;
        }



        public IActionResult Index()
        {
            var icecekListesi = icecekiService.IcecekListele();
            var tatliListesi = tatliService.TatliListele();
            var kategori = kategoriService.KategoriListele();

            var viewModel = new MenuViewModel
            {
                Iceceklers = icecekListesi,
                Tatlilars = tatliListesi,
                Kategoris = kategori
            };

            return View(viewModel);
        }
    }
}
