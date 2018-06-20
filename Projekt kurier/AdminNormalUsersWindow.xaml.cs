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
    /// Interaction logic for AdminNormalUsersWindow.xaml
    /// </summary>
    public partial class AdminNormalUsersWindow : Window
    {
        public AdminNormalUsersWindow()
        {
            InitializeComponent();
            EditButton.IsEnabled = false;
            DeleteButton.IsEnabled = false;
            NormalUsersListBox.ItemsSource = DB.Instance.Users;
        }
        private ListCollectionView View
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(DB.Instance.Users);
            }
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            AddNormalUserWindow win = new AddNormalUserWindow();
            win.Owner = this;
            win.ShowDialog();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            EditNormalUserDataWindow win = new EditNormalUserDataWindow();
            win.Owner = this;
            win.DataContext = NormalUsersListBox.SelectedItem;
            win.ShowDialog();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user = (User)NormalUsersListBox.SelectedItem;
            for (int i = 0; i < DB.PackagesList.Count(); i++)
                if (user == DB.PackagesList[i].Sender)
                    DB.PackagesList[i].Sender = null;
            DB.UsersList.RemoveAt(NormalUsersListBox.SelectedIndex);
            NormalUsersListBox.Items.Refresh();
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
            View.SortDescriptions.Add(new SortDescription("UserSurname", ListSortDirection.Ascending));
        }


        private void IdSort_Selected(object sender, RoutedEventArgs e)
        {
            View.SortDescriptions.Clear();
            View.SortDescriptions.Add(new SortDescription("Login", ListSortDirection.Ascending));
        }

        private void NormalUsersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(NormalUsersListBox.SelectedIndex>=0)
            {
                EditButton.IsEnabled = true;
                DeleteButton.IsEnabled = true;
            }
            else
            {
                EditButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
        }

        private void SearchId(object sender, RoutedEventArgs e)
        {
            if (SearchIDTextBox.Text == string.Empty)
            {
                NormalUsersListBox.ItemsSource = DB.UsersList;
                return;
            }
            var filtered = from co in DB.UsersList
                           let id = co.Login
                           where id.Contains(SearchIDTextBox.Text)
                           select co;
            NormalUsersListBox.ItemsSource = filtered;
        }
    }
}