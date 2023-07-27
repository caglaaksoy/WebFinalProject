using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Siniflar
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAd { get; set; }
        public ICollection<Tatlilar> Tatlilars { get; set; }
        public ICollection<Icecekler> Iceceklers { get; set; }
    }
}
