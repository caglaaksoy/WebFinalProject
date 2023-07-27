using DataAccessLayer.Data;
using DataAccessLayer.Services;
using EntityLayer.Siniflar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Actions
{
    public class IcecekService : IIcecekiService
    {

        readonly delalalaDBContext c = new delalalaDBContext();

        public List<Icecekler> IcecekListele()
        {
            var degerler = c.Iceceklers.Include(i => i.Kategori).ToList();
            return c.Iceceklers.ToList();
        }

        public void IcecekEkle(Icecekler icecekler)
        {
            //var kategori = c.Kategoris.FirstOrDefault(kt => kt.Id == tatli.Kategori.Id);
            //t.Kategori = kategori;
            //c.Tatlilars.Add(tatli);

            var kategori = c.Kategoris.FirstOrDefault(kt => kt.Id == icecekler.Kategori.Id);
            icecekler.Kategori = kategori;
            c.Iceceklers.Add(icecekler);
            c.SaveChanges();
        }

        public void IcecekSil(int id)
        {
            var i = c.Iceceklers.Find(id);
            if (i != null)
            {
                c.Iceceklers.Remove(i);
                c.SaveChanges();
            }
        }

        public void IcecekGuncelle(Icecekler icecekler)
        {
            var icecek = c.Iceceklers.Find(icecekler.Id);
            if (icecek != null)
            {
                icecek.UrunAdi = icecekler.UrunAdi;
                icecek.UrunTanim = icecekler.UrunTanim;
                icecek.UrunFiyat = icecekler.UrunFiyat;
                icecek.UrunFoto = icecekler.UrunFoto;

                c.SaveChanges();
            }
        }
    }
}
