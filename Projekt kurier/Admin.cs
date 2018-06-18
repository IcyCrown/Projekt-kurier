using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_kurier
{
    public class Admin
    {
        public string AdminLogin { get; set; }
        public string AdminPassword { get; set; }

        public Admin() { }
        public Admin(string login, string password)
        {
            AdminLogin = login;
            AdminPassword = password;
        }
    }
}
