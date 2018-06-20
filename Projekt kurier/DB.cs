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
        public static ObservableCollection<User> UsersList = new ObservableCollection<User>();
        public static ObservableCollection<Courier> CouriersList = new ObservableCollection<Courier>();
        public static Admin Administrator = new Admin("admin", "password");
        public static ObservableCollection<Package> PackagesList = new ObservableCollection<Package>();

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

        public void AddUser(User item)
        {
            UsersList.Add(item);
        }
        public User GetUser(int id)
        {
            return UsersList[id];
        }
        public ObservableCollection<User> Users
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
        public Courier GetCourier(int id)
        {
            return CouriersList[id];
        }
        public ObservableCollection<Courier> Couriers
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
        public ObservableCollection<Package> Packages
        {
            get
            {
                return PackagesList;
            }
        }

        public static void Save()
        {
            System.Xml.Serialization.XmlSerializer writerU = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<User>));
            System.Xml.Serialization.XmlSerializer writerP = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<Package>));
            System.Xml.Serialization.XmlSerializer writerC = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<Courier>));
            System.Xml.Serialization.XmlSerializer writerA = new System.Xml.Serialization.XmlSerializer(typeof(Admin));

            var pathU = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationUserOverview.xml";
            var pathP = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationPackageOverview.xml";
            var pathC = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationCourierOverview.xml";
            var pathA = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationAdminOverview.xml";

            System.IO.FileStream fileU = System.IO.File.Create(pathU);
            System.IO.FileStream fileP = System.IO.File.Create(pathP);
            System.IO.FileStream fileC = System.IO.File.Create(pathC);
            System.IO.FileStream fileA = System.IO.File.Create(pathA);

            writerU.Serialize(fileU, UsersList);
            writerP.Serialize(fileP, PackagesList);
            writerC.Serialize(fileC, CouriersList);
            writerA.Serialize(fileA, Administrator);

            fileU.Close();
            fileP.Close();
            fileC.Close();
            fileA.Close();
        }
        public static void Read()
        {
            var readerU = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<User>));
            var readerP = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<Package>));
            var readerC = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<Courier>));
            var readerA = new System.Xml.Serialization.XmlSerializer(typeof(Admin));

            var fileU = new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationUserOverview.xml");
            var fileP = new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationPackageOverview.xml");
            var fileC = new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationCourierOverview.xml");
            var fileA = new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationAdminOverview.xml");

            UsersList = (ObservableCollection<User>)readerU.Deserialize(fileU);
            PackagesList = (ObservableCollection<Package>)readerP.Deserialize(fileP);
            CouriersList = (ObservableCollection<Courier>)readerC.Deserialize(fileC);
            Administrator = (Admin)readerA.Deserialize(fileA);

            fileU.Close();
            fileP.Close();
            fileC.Close();
            fileA.Close();
        }
    }
}
