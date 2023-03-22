using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2
{
    public class Produs
    {
        public int ID { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public DateTime Intrare { get; set; }
        public DateTime Valabilitate { get; set; }
        public int Cantitate { get; set; }
    }

    public class ProdusDbContext : DbContext
    {
        public DbSet<Produs> Produse { get; set; }
    }
}
