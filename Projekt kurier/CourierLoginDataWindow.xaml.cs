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
    /// Interaction logic for CourierLoginDataWindow.xaml
    /// </summary>
    public partial class CourierLoginDataWindow : Window
    {
        public CourierLoginDataWindow()
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if(NewPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Podane hasła się różnią!");
                return;
            }
            Courier c = null;
            c = (from courier in DB.CouriersList
                 where courier.Login == NewLoginTextBox.Text
                 select courier).First();
            if (c != null && NewLoginTextBox.Text != ((CourierWindow)Owner).CurrentCourier.Login)
            {
                MessageBox.Show("Podany login jest zajęty!");
                NewLoginTextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            ((CourierWindow)Owner).CurrentCourier.Login = NewLoginTextBox.Text;
            ((CourierWindow)Owner).CurrentCourier.Password = NewPasswordTextBox.Text;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
