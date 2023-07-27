using EntityLayer.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public interface IKategoriService
    {
        List<Kategori> KategoriListele();
    }
}
