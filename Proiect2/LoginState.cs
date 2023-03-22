using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2
{
    internal class LoginState
    {
        public static bool IsLoggedIn { get; set; }
        public static int id { get; set; }
        public static string nume { get; set; }
        public static string prenume { get; set; }
        public static string username { get; set; }
        public static bool isAdmin { get; set; }

    }
}
