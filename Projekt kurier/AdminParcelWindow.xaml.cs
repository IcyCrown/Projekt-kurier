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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class AdminParcelWindow : Window
    {
        public AdminParcelWindow()
        {
            InitializeComponent();
            PackagesListBox.ItemsSource = DB.PackagesList;
        }

        private void Assign(object sender, RoutedEventArgs e)
        {
            AssignParcelWindow win = new AssignParcelWindow();
            win.Owner = this;
            win.ShowDialog();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            EditParcelDataWindow win = new EditParcelDataWindow();
            win.Owner = this;
            win.ShowDialog();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {

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
    }
}
