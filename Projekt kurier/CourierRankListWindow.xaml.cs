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
    /// Interaction logic for CourierRankListWindow.xaml
    /// </summary>
    public partial class CourierRankListWindow : Window
    {
        public CourierRankListWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Courier> ranking = new List<Courier>(DB.CouriersList);
            ranking = ranking.OrderByDescending(o => o.DeliveredPackagesCount).ToList();
            RankListBox.ItemsSource = ranking;
        }
    }
}
