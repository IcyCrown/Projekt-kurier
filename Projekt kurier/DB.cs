using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_kurier
{
    /// <summary>
    /// Klasa statyczna przechowująca listy użytkowników, kurierów i paczek, a także obiekt klasy Admin
    /// Chwilowo traktujemy ją jako bazę danych, później zdecyduje się czy zmieniamy to na bazę danych czy dodajemy metody zapisu i odczytu z pliku
    /// </summary>
    static class DB
    {
        public static List<User> UsersList = new List<User>();
        public static List<Courier> CouriersList = new List<Courier>();
        public static Admin Administrator = new Admin("admin", "password");

        public static List<Package> PackagesList = new List<Package>();
    }
}
