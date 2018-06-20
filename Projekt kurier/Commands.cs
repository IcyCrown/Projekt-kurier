using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt_kurier
{
    public static class Commands
    {
        public static readonly RoutedUICommand Close = new RoutedUICommand("Zamknij okno", "Zamknij", typeof(Commands));
    }
}
