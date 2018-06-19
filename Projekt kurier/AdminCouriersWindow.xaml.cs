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
using System.ComponentModel;

namespace Projekt_kurier
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class AdminCouriersWindow : Window
    {
        public AdminCouriersWindow()
        {
            InitializeComponent();
            CouriersListBox.ItemsSource = DB.Instance.Couriers;
        }

        private ListCollectionView View
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(DB.Instance.Couriers);
            }
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            AddCourierWindow win = new AddCourierWindow();
            win.Owner = this;
            win.ShowDialog();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            EditCourierDataWindow win = new EditCourierDataWindow();
            win.Owner = this;
            win.DataContext = CouriersListBox.SelectedItem;
            win.ShowDialog();

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            Courier courier = new Courier();
            courier = (Courier)CouriersListBox.SelectedItem;
            for (int i = 0; i < DB.PackagesList.Count(); i++)
                if (courier == DB.PackagesList[i].AssignedCourier)
                    DB.PackagesList[i].AssignedCourier = null;
            DB.CouriersList.RemoveAt(CouriersListBox.SelectedIndex);
            CouriersListBox.Items.Refresh();
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NoSort_Selected(object sender, RoutedEventArgs e)
        {
            View.SortDescriptions.Clear();
        }

        private void SurnameSort_Selected(object sender, RoutedEventArgs e)
        {
            View.SortDescriptions.Clear();
            View.SortDescriptions.Add(new SortDescription("Surname", ListSortDirection.Ascending));
        }


        private void IdSort_Selected(object sender, RoutedEventArgs e)
        {
            View.SortDescriptions.Clear();
            View.SortDescriptions.Add(new SortDescription("Login", ListSortDirection.Ascending));
        }

    }
}
