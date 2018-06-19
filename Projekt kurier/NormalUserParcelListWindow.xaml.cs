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
using System.Collections;
using System.Globalization;
using System.Windows.Navigation;
using System.ComponentModel;


namespace Projekt_kurier
{
    /// <summary>
    /// Interaction logic for UserParcelListWindow.xaml
    /// </summary>
    public partial class NormalUserParcelListWindow : Window
    {
        public NormalUserParcelListWindow()
        {
                InitializeComponent();
        }

        private void userListBox_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            userListBox.Items.Refresh();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                userListBox.ItemsSource = from package in DB.PackagesList
                                              where package.Sender.Login == ((NormalUserWindow)Owner).CurrentUser.Login
                                              select package;
            }
            catch (NullReferenceException) { }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            DB.PackagesList.RemoveAt(userListBox.SelectedIndex);
            userListBox.Items.Refresh();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EditParcelDataWindow epdw = new EditParcelDataWindow();
            epdw.Owner = this;
            epdw.DataContext = this;
            epdw.ShowDialog();
        }

        public ListCollectionView View
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(DB.PackagesList);
            }
        }
        private void ParcelStatusSort_Selected(object sender, RoutedEventArgs e)
        {
            View.SortDescriptions.Clear();
            View.SortDescriptions.Add(new SortDescription("State", ListSortDirection.Descending));
            userListBox.Items.Refresh();
        }
        private void SortCancel_Selected(object sender, RoutedEventArgs e)
        {
            View.SortDescriptions.Clear();
        }
        private void IDSearch_Clicked(object sender, RoutedEventArgs e)
        {
            decimal id;
            if (Decimal.TryParse(IDSearch.Text, out id))
            {
                View.Filter = delegate (object item)
                {
                    Package package = item as Package;
                    if (package != null)
                    {
                        return (userListBox.Items.IndexOf(package) == id);
                    }
                    return false;
                };
            }
            userListBox.Items.Refresh();
        }
        private void ParcelIDSort_Selected(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
