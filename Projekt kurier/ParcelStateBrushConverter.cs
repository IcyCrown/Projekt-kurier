using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace Projekt_kurier
{
    class ParcelStateBrushConverter : IValueConverter 
    {
        public Brush PendingBrush { get; set; }
        public Brush DeliveredBrush { get; set; }
        public Brush CancelledBrush { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PackageState val = (PackageState)value;
            switch (val)
            {
                case PackageState.Pending:
                    return PendingBrush;
                case PackageState.Cancelled:
                    return CancelledBrush;
                case PackageState.Delivered:
                    return DeliveredBrush;
            }
            return PendingBrush;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
