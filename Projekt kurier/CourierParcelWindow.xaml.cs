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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt_kurier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CourierParcelWindow : Window
    {
        public CourierParcelWindow()
        {
            InitializeComponent();
        }

        private void ChangeStatus(object sender, RoutedEventArgs e)
        {
            ChangeStatusWindow win = new ChangeStatusWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void ShowDescription(object sender, RoutedEventArgs e)
        {
            DescriptionWindow win = new DescriptionWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                PackagesListBox.ItemsSource = from package in DB.PackagesList
                                              where package.AssignedCourier.Login == ((CourierWindow)Owner).CurrentCourier.Login
                                              select package;
            }
            catch (NullReferenceException) { }
        }
    }
}
