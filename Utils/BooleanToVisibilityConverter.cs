using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Utils
{
    internal class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if(typeof(bool) == value.GetType())
            {
                var val = (bool)value;
                return val ? Visibility.Visible : Visibility.Collapsed;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if(typeof(Visibility) == value.GetType())
            {
                var vis = (Visibility)value;
                return vis == Visibility.Visible ? true : false;
            }
            return null;
        }
    }
}
