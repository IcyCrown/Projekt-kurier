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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ListCollectionView View
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(DB.PackagesList);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SqareResize(object sender, SizeChangedEventArgs e)
        {
            this.Height = this.Width + 21.5;
        }
        private void NormalLogin(object sender, RoutedEventArgs e)
        {
            NormalUserLoginWindow win = new NormalUserLoginWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void CourierLogin(object sender, RoutedEventArgs e)
        {
            CourierLoginWindow win = new CourierLoginWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void AdminLogin(object sender, RoutedEventArgs e)
        {
            AdminLoginWindow win = new AdminLoginWindow();
            win.Owner = this;
            win.ShowDialog(); 
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
