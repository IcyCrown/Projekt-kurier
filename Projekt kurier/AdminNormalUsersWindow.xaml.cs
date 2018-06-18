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
    /// Interaction logic for AdminNormalUsersWindow.xaml
    /// </summary>
    public partial class AdminNormalUsersWindow : Window
    {
        public AdminNormalUsersWindow()
        {
            InitializeComponent();
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
            win.ShowDialog();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }
        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}