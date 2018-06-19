using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekt_kurier
{
    /// <summary>
    /// Interaction logic for AddEdit.xaml
    /// </summary>
    public partial class AddParcelWindow : Window
    {
        public AddParcelWindow()
        {
            InitializeComponent();
        }
    
    private void Add(object sender, RoutedEventArgs e)
        {
            // to trzeba będzie dodać jak już będziemy mieli ogarnięte logowanie
            //User userSender = (User)from user in DB.UsersList
            //              where user.UserName == senderName.Text && user.UserSurname == senderSurname.Text && user.UserAddress == senderAddress.Text
            //              select user;
            User userSender = ((NormalUserWindow)Owner).CurrentUser;
            DB.PackagesList.Add(new Package(userSender, recipientName.Text, recipientSurname.Text, recipientAddress.Text, description.Text));
            DB.PackagesList.Last().State = PackageState.Pending;
            Close();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
