using System;
using System.Linq;
using Xamarin.Forms;

namespace Lbc.Converters {
    public class TwoLetterConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            var str = (string)value;
            if (string.IsNullOrWhiteSpace(str))
                return "";

            //return str.Substring(0, 2);
            return string.Join("", str.ToCharArray().Take(2));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
