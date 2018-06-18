using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_kurier
{
    public class User
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserAddress { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }


        public User() { }
        public User(string name, string surname, string address)
        {
            UserName = name;
            UserSurname = surname;
            UserAddress = address;
        }
        public User(string name, string surname, string address, string login, string password)
        {
            UserName = name;
            UserSurname = surname;
            UserAddress = address;
            Login = login;
            Password = password;
        }
    }
}
