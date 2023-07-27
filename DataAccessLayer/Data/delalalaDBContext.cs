using EntityLayer.Siniflar;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{

    public class delalalaDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server = DESKTOP-IV1U5H1\\SQLEXPRESS;database=delalaDb; integrated security=true;TrustServerCertificate=True");
            
        }



            public DbSet<Icecekler> Iceceklers { get; set; }
            public DbSet<Kategori> Kategoris { get; set; }
            public DbSet<Kullanici> Kullanicis { get; set; }
            public DbSet<Tatlilar> Tatlilars { get; set; }
        
    

}
}
