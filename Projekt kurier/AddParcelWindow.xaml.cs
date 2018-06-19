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
    /// Interaction logic for AddEdit.xaml
    /// </summary>
    public partial class AddParcelWindow : Window
    {
        public AddParcelWindow()
        {
            InitializeComponent();
        }
    
    private void Add(object sender, RoutedEventArgs e)
        {
            User userSender = ((NormalUserWindow)Owner).CurrentUser;
            DB.PackagesList.Add(new Package(userSender, recipientName.Text, recipientSurname.Text, recipientAddress.Text, description.Text));
            DB.PackagesList.Last().State = PackageState.Pending;
            Close();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
