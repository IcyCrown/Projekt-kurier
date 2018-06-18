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
    /// Interaction logic for UserParcelListWindow.xaml
    /// </summary>
    public partial class NormalUserParcelListWindow : Window
    {
        public NormalUserParcelListWindow()
        {
            InitializeComponent();
            userListBox.ItemsSource = DB.PackagesList;
        }

        private void userListBox_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            userListBox.Items.Refresh();
        }
    }
}
