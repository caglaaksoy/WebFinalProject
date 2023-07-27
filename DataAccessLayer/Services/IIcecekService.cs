using EntityLayer.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Services
{
    public interface IIcecekiService
    {
        List<Icecekler> IcecekListele();
        void IcecekEkle(Icecekler icecek);
        void IcecekSil(int id);
        void IcecekGuncelle(Icecekler icecek);

    }
}
