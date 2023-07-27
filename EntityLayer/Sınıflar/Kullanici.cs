using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Siniflar
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
    }
}
