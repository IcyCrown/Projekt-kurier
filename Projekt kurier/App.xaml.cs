using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Projekt_kurier
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var binding = new CommandBinding(Commands.Close, DoSomething, CanDoSomething);

            // Register CommandBinding for all windows.
            CommandManager.RegisterClassCommandBinding(typeof(Window), binding);
        }

        private void DoSomething(object sender, ExecutedRoutedEventArgs e)
        {
            if (sender is Window) ((Window)sender).Close();
            else
            {
                Window parent = Window.GetWindow((UIElement)sender);
            }
        }

        private void CanDoSomething(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            DB.Save();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            DB.Read();
        }
    }
}
