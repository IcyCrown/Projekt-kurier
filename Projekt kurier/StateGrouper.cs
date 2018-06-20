using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;

namespace Projekt_kurier
{
    class StateGrouper : IValueConverter
    {
        public int StateInterval { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string state = value.ToString();
            if (state == "Pending")
            {
                return String.Format(culture, "W trakcie dostawy", StateInterval);
            }
            else if (state == "Delivered")
            {
                return String.Format(culture, "Dostarczone", StateInterval);
            }
            else
            {
                return String.Format(culture, "Anulowane", StateInterval);
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
