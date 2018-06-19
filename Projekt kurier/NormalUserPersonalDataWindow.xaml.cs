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
    /// Interaction logic for UserPersonalData.xaml
    /// </summary>
    public partial class NormalUserPersonalDataWindow : Window
    {
        public NormalUserPersonalDataWindow()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if(NameTextBox.Text == String.Empty || SurnameTextBox.Text == String.Empty || AddressTextBox.Text == String.Empty || 
                NewLoginTextBox.Text == String.Empty || NewPasswordPasswordBox.Password == String.Empty || ConfirmPasswordPasswordBox.Password == String.Empty)
            {
                MessageBox.Show("Uzupełnij puste pola!");
                return;
            }
            if(NewPasswordPasswordBox.Password != ConfirmPasswordPasswordBox.Password)
            {
                MessageBox.Show("Podane hasła się różnią!");
                ConfirmPasswordPasswordBox.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            User u = null;
            try
            {
                u = (from user in DB.UsersList
                          where user.Login == NewLoginTextBox.Text
                          select user).First();
            }
            // jeżeli jakimś cudem nie ma użytkowników
            catch(Exception) { }
            // jeżeli znalazło innego niż obecny użytkownika o podanym loginie
            if(u != null && NewLoginTextBox.Text != ((NormalUserWindow)Owner).CurrentUser.Login)
            {
                MessageBox.Show("Podany login jest zajęty!");
                NewLoginTextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            User cu = ((NormalUserWindow)Owner).CurrentUser; User DBcu = (from user in DB.UsersList
                                                                    where user.Login == cu.Login
                                                                    select user).First();
            cu.UserName = DBcu.UserName = NameTextBox.Text;
            cu.UserSurname = DBcu.UserSurname = SurnameTextBox.Text;
            cu.Login = DBcu.Login = NewLoginTextBox.Text;
            cu.Password = DBcu.Password = NewPasswordPasswordBox.Password;
            MessageBox.Show("Pomyślnie zmieniono dane!");
        }
    }
}
