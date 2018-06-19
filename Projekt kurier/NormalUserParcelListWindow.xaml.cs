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
    }
}
