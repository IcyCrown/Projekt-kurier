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
    /// Interaction logic for AddCourierWindow.xaml
    /// </summary>
    public partial class AddCourierWindow : Window
    {
        public AddCourierWindow()
        {
            InitializeComponent();
        }
         public void AddCourier(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text == String.Empty || SurnameTextBox.Text == String.Empty ||  LoginTextBox.Text == String.Empty || PasswordTextBox.Text == String.Empty)
            {
                MessageBox.Show("Uzupełnij puste pola!");
                return;
            }
            Courier us = null;
            try
            {
                us = DB.CouriersList.Where(u => u.Login == LoginTextBox.Text).Single();
            }
            catch (Exception) { }
            if (us != null)
            {
                MessageBox.Show("Podany login jest zajety!");
                return;
            }
            DB.CouriersList.Add(new Courier(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text, SurnameTextBox.Text));
            MessageBox.Show("Rejestracja powiodła się!");
            Close();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
