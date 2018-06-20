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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class AdminParcelWindow : Window
    {
        public AdminParcelWindow()
        {
            InitializeComponent();
            AssignButton.IsEnabled = false;
            DescriptionButton.IsEnabled = false;
            EditButton.IsEnabled = false;
            ChangeStatusButton.IsEnabled = false;
            DeleteButton.IsEnabled = false;
            PackagesListBox.ItemsSource = DB.PackagesList;
        }

        private ListCollectionView View
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(DB.Instance.Packages);
            }
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
            View.Refresh();
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

        private void PackagesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PackagesListBox.SelectedIndex >= 0)
            {
                AssignButton.IsEnabled = true;
                DescriptionButton.IsEnabled = true;
                EditButton.IsEnabled = true;
                ChangeStatusButton.IsEnabled = true;
                DeleteButton.IsEnabled = true;
            }
            else
            {
                AssignButton.IsEnabled = false;
                DescriptionButton.IsEnabled = false;
                EditButton.IsEnabled = false;
                ChangeStatusButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
        }
        private void NoSort_Selected(object sender, RoutedEventArgs e)
        {
            View.SortDescriptions.Clear();
            View.Refresh();
        }

        private void StatusPackageSort_Selected(object sender, RoutedEventArgs e)
        {
            View.SortDescriptions.Clear();
            View.SortDescriptions.Add(new SortDescription("State", ListSortDirection.Ascending));
            View.Refresh();
        }


        private void IdSort_Selected(object sender, RoutedEventArgs e)
        {
            View.SortDescriptions.Clear();
            View.SortDescriptions.Add(new SortDescription("Login", ListSortDirection.Ascending));
            View.Refresh();
        }

        private void NoGroup_Selected(object sender, RoutedEventArgs e)
        {
            View.GroupDescriptions.Clear();
            View.Refresh();
        }

        private void StateGroup_Selected(object sender, RoutedEventArgs e)
        {
            View.CustomSort = new SortByState();
            StateGrouper grouper = new StateGrouper();
            View.GroupDescriptions.Add(new PropertyGroupDescription("State", grouper));
            View.Refresh();
        }
    }
}
