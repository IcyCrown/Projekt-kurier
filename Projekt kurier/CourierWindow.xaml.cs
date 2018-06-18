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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class CourierWindow : Window
    {
        public Courier CurrentCourier = new Courier();
        public CourierWindow()
        {
            InitializeComponent();
        }
        private void SqareResize(object sender, SizeChangedEventArgs e)
        {
            this.Height = this.Width + 21.5;
        }
        private void ParcelList(object sender, RoutedEventArgs e)
        {
            CourierParcelWindow win = new CourierParcelWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void CourierRankList(object sender, RoutedEventArgs e)
        {
            CourierRankListWindow win = new CourierRankListWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void ChangeLoginData(object sender, RoutedEventArgs e)
        {
            CourierLoginDataWindow win = new CourierLoginDataWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
