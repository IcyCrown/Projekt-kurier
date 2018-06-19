using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Projekt_kurier
{
    /// <summary>
    /// Klasa statyczna przechowująca listy użytkowników, kurierów i paczek, a także obiekt klasy Admin
    /// Chwilowo traktujemy ją jako bazę danych, później zdecyduje się czy zmieniamy to na bazę danych czy dodajemy metody zapisu i odczytu z pliku
    /// </summary>
    public class DB
    {
        private static Collection<User> UsersList = new ObservableCollection<User>();
        private static Collection<Courier> CouriersList = new ObservableCollection<Courier>();
        private static Admin Administrator = new Admin("admin", "password");
        private static Collection<Package> PackagesList = new ObservableCollection<Package>();

        public DB() { }

        private static DB singleton = null;
        public static DB Instance
        {
            get
            {
                if (singleton == null)
                    singleton = new DB();
                return singleton;
            }
        }

        public void AddUser (User item)
        {
            UsersList.Add(item);
        }
        public User GetUser(int id)
        {
            return UsersList[id];
        }
        public Collection<User> Users
        {
            get
            {
                return UsersList;
            }
        }

        public void AddCourier(Courier item)
        {
            CouriersList.Add(item);
        }
        public Courier GetCourier (int id)
        {
            return CouriersList[id];
        }
        public Collection<Courier> Couriers
        {
            get
            {
                return CouriersList;
            }
        }

        public void AddPackage(Package item)
        {
            PackagesList.Add(item);
        }
        public Package GetPackage(int id)
        {
            return PackagesList[id];
        }
        public Collection<Package> Packages
        {
            get
            {
                return PackagesList;
            }
        }

    }
}
