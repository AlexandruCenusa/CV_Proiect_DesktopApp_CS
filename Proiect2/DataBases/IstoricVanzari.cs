using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2
{
    public class IstoricVanzari
    {
        public int ID { get; set; }
        public int ID_user { get; set; }
        public string Produs { get; set; }
        public int Cantitate { get; set; }
    }

    public class IstoricVanzariDbContext : DbContext
    {
        public DbSet<IstoricVanzari> Istoric { get; set; }
    }
}
