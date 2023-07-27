using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Siniflar
{
    public class Tatlilar
    {
        [Key]
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string UrunTanim { get; set; }
        public int UrunFiyat { get; set; }
        public string UrunFoto { get; set; }
        public Kategori Kategori { get; set; }

    }
}
