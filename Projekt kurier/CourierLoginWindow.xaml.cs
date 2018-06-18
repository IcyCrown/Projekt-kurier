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
    public partial class CourierLoginWindow : Window
    {
        public CourierLoginWindow()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            CourierWindow win = new CourierWindow();
            win.Owner = this;
            Courier co = DB.CouriersList.Find(u => u.Login == IDTextBox.Text || u.Password == PasswordTextBox.Text);
            if (co == null)
            {
                MessageBox.Show("Podane dane są nieprawidłowe!");
                return;
            }
            win.CurrentCourier = co;
            win.ShowDialog();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
