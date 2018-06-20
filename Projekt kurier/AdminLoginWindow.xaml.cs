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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class AdminLoginWindow : Window
    {
        public AdminLoginWindow()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            AdminWindow win = new AdminWindow();
            win.Owner = this.Owner;
            if (IDTextBox.Text != DB.Administrator.AdminLogin || PasswordTextBox.Password != DB.Administrator.AdminPassword)
            {
                MessageBox.Show("Podane dane są nieprawidłowe!");
                return;
            }
            this.Close();
            win.ShowDialog();
        }
    }
}
