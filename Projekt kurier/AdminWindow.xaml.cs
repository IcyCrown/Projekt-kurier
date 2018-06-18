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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }
        private void SqareResize(object sender, SizeChangedEventArgs e)
        {
            this.Height = this.Width + 21.5;
        }
        private void Logout(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ManageCouriers(object sender, RoutedEventArgs e)
        {
            AdminCouriersWindow win = new AdminCouriersWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void ManageParcels(object sender, RoutedEventArgs e)
        {
            AdminParcelWindow win = new AdminParcelWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void ChangeLoginData(object sender, RoutedEventArgs e)
        {
            AdminNormalUsersWindow win = new AdminNormalUsersWindow();
            win.Owner = this;
            win.ShowDialog();
        }

    }
}
