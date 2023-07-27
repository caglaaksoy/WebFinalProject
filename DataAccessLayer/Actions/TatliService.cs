using DataAccessLayer.Data;
using DataAccessLayer.Services;
using EntityLayer.Siniflar;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Actions
{
    public class TatliService : ITatliService
    {
        readonly delalalaDBContext c = new delalalaDBContext();

        public List<Tatlilar> TatliListele()
        {
            var degerler = c.Tatlilars.Include(t => t.Kategori).ToList();
            return c.Tatlilars.ToList();
        }

        public void TatliEkle(Tatlilar tatlilar)
        {
            var kategori = c.Kategoris.FirstOrDefault(kt => kt.Id == tatlilar.Kategori.Id);
            tatlilar.Kategori = kategori;
            c.Tatlilars.Add(tatlilar);
            c.SaveChanges();
        }

        public void TatliSil(int id)
        {
            var t = c.Tatlilars.Find(id);
            if (t != null)
            {
                c.Tatlilars.Remove(t);
                c.SaveChanges();
            }
        }

        public void TatliGuncelle(Tatlilar tatlilar)
        {
            var tatli = c.Tatlilars.Find(tatlilar.Id);
            if (tatli != null)
            {
                tatli.UrunAdi = tatlilar.UrunAdi;
                tatli.UrunTanim = tatlilar.UrunTanim;
                tatli.UrunFiyat = tatlilar.UrunFiyat;
                tatli.UrunFoto = tatlilar.UrunFoto;

                c.SaveChanges();
            }
        }

    }
}
