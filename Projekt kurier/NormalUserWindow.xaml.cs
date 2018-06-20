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
    public partial class NormalUserWindow : Window
    {
        public User CurrentUser = new User();
        public NormalUserWindow()
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

        private void SendParcel(object sender, RoutedEventArgs e)
        {
            AddParcelWindow win = new AddParcelWindow();
            win.Owner = this;
            win.DataContext = CurrentUser;
            win.ShowDialog(); 
        }

        private void SendersPersonalData(object sender, RoutedEventArgs e)
        {
            NormalUserPersonalDataWindow win = new NormalUserPersonalDataWindow();
            win.Owner = this;
            win.DataContext = CurrentUser;
            win.ShowDialog(); 
        }

        private void ShowList(object sender, RoutedEventArgs e)
        {
            NormalUserParcelListWindow win = new NormalUserParcelListWindow();
            win.Owner = this;
            win.ShowDialog();
        }
    }
}
