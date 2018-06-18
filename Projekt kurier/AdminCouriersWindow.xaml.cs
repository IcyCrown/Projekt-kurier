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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class AdminCouriersWindow : Window
    {
        public AdminCouriersWindow()
        {
            InitializeComponent();
            CouriersListBox.ItemsSource = DB.CouriersList;
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
