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
    /// Logika interakcji dla klasy ParcelStatusInfoWindow.xaml
    /// </summary>
    public partial class ParcelStatusInfoWindow : Window
    {
        public SettingSource WindowSettings
        {
            get;
            set;
        }
        public ParcelStatusInfoWindow() {
            InitializeComponent();

        }
        public ParcelStatusInfoWindow(SettingSource setting)
        {
            InitializeComponent();
            this.WindowSettings = setting;
            this.DataContext = setting;
        }
        
        private void OkButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
