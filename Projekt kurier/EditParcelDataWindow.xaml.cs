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
    /// Interaction logic for EditParcelData.xaml
    /// </summary>
    public partial class EditParcelDataWindow : Window
    {
        public EditParcelDataWindow()
        {
            InitializeComponent();
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = senderName.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
            binding = senderSurname.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
            binding = senderAddress.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
            binding = recipientName.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
            binding = recipientSurname.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
            binding = recipientAddress.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
            binding = description.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
