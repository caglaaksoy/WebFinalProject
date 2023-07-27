using EntityLayer.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public interface ITatliService
    {
        List<Tatlilar> TatliListele();
        void TatliEkle(Tatlilar tatli);
        void TatliSil(int id);
        void TatliGuncelle(Tatlilar tatli);

    }
}
