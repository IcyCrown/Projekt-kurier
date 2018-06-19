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
    /// Interaction logic for StatusWindow.xaml
    /// </summary>
    public partial class ChangeStatusWindow : Window
    {
        public ChangeStatusWindow()
        {
            InitializeComponent();
        }
        void SetPackageDelivered(object sender, RoutedEventArgs e)
        {
            Package package;
            if (Owner is CourierParcelWindow) { package = (Package)((CourierParcelWindow)Owner).PackagesListBox.SelectedItem; }
            else { package = (Package)((AdminParcelWindow)Owner).PackagesListBox.SelectedItem; }
            package.State = PackageState.Delivered;
        }
        void SetPackageAssigned(object sender, RoutedEventArgs e)
        {
            Package package;
            if (Owner is CourierParcelWindow) { package = (Package)((CourierParcelWindow)Owner).PackagesListBox.SelectedItem; }
            else { package = (Package)((AdminParcelWindow)Owner).PackagesListBox.SelectedItem; }
        }
        void SetPackageCancelled(object sender, RoutedEventArgs e)
        {
            Package package;
            if (Owner is CourierParcelWindow) { package = (Package)((CourierParcelWindow)Owner).PackagesListBox.SelectedItem; }
            else { package = (Package)((AdminParcelWindow)Owner).PackagesListBox.SelectedItem; }
            package.State = PackageState.Cancelled;
        }
    }
}
