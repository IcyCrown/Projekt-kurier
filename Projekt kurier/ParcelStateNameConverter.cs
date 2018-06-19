using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace Projekt_kurier
{
    class ParcelStateNameConverter : IValueConverter
    {
        public string Pending { get; set; }
        public string Delivered { get; set; }
        public string Cancelled { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PackageState val = (PackageState)value;
            switch (val)
            {
                case PackageState.Pending:
                    return Pending;
                case PackageState.Cancelled:
                    return Cancelled;
                case PackageState.Delivered:
                    return Delivered;
            }
            return Pending;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
