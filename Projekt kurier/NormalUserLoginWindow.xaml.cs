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
    /// Interaction logic for NormalUserLoginWindow.xaml
    /// </summary>
    public partial class NormalUserLoginWindow : Window
    {
        public NormalUserLoginWindow()
        {
            InitializeComponent();
        }
        private void Login(object sender, RoutedEventArgs e)
        {
            NormalUserWindow win = new NormalUserWindow();
            win.Owner = this.Owner;
            User us = null;
            try
            {
                us = DB.UsersList.Where(u => u.Login == IDTextBox.Text && u.Password == PasswordTextBox.Password).Single();
            }
            catch (Exception) { }
            if (us == null)
            {
                MessageBox.Show("Podane dane są nieprawidłowe!");
                return;
            }
            win.CurrentUser = us;
            this.Close();
            win.ShowDialog();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            AddNormalUserWindow anuw = new AddNormalUserWindow();
            anuw.Show();
        }
    }
}
