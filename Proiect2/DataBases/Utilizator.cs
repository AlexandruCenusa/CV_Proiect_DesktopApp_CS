using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2
{
    public class Utilizator
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Username { get; set;}
        public string Password { get; set;}
        public bool IsAdmin { get; set; }
    }

    public class UtilizatorDbContext : DbContext
    {
        public DbSet<Utilizator> Utilizatori { get; set; }
    }
}
