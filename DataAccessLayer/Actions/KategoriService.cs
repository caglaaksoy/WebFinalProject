using DataAccessLayer.Data;
using DataAccessLayer.Services;
using EntityLayer.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Actions
{
    public class KategoriService : IKategoriService
    {
        private readonly delalalaDBContext c;

        public KategoriService(delalalaDBContext c)
        {
            this.c = c;
        }

        public List<Kategori> KategoriListele()
        {
            return c.Kategoris.ToList();
        }

    }
}
