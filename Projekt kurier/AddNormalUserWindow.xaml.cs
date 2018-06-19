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
    /// Interaction logic for AddNormalUserWindow.xaml
    /// </summary>
    public partial class AddNormalUserWindow : Window
    {
        public AddNormalUserWindow()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (NameTB.Text == String.Empty || SurnameTB.Text == String.Empty || AddressTB.Text == String.Empty
                || LoginTB.Text == String.Empty || PasswordTB.Text == String.Empty)
            {
                MessageBox.Show("Uzupełnij puste pola!");
                return;
            }
            User us = null;
            try
            {
                us = DB.UsersList.Where(u => u.Login == LoginTB.Text).Single();
            }
            catch (Exception) { }
            if(us != null)
            {
                MessageBox.Show("Podany login jest zajety!");
                return;
            }
            DB.UsersList.Add(new User(NameTB.Text, SurnameTB.Text, AddressTB.Text, LoginTB.Text, PasswordTB.Text));
            MessageBox.Show("Rejestracja powiodła się!");
            Close();
        }
    }
}
