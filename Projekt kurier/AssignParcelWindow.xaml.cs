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
    /// Interaction logic for AssignParcelWindow.xaml
    /// </summary>
    public partial class AssignParcelWindow : Window
    {
        public AssignParcelWindow()
        {
            InitializeComponent();
        }

        private void Assign(object sender, RoutedEventArgs e)
        {
            try
            {

                Package package = (Package)((AdminParcelWindow)Owner).PackagesListBox.SelectedItem;
                package.AssignedCourier = (from courier in DB.CouriersList
                                           where courier.Login == AssingTextBox.Text
                                           select courier).First();
                package.State = PackageState.Assigned;
            }
            catch (InvalidOperationException) { MessageBox.Show("Kurier o podanym loginie nie istnieje!"); }
            Close();
        }
    }
}