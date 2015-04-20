using Lbc.WebApi.Modes;
using System;
using System.Linq;
using Xamarin.Forms;

namespace Lbc.Converters {
    public class LocConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            var co = (ShortConsignDto)value;
            if (co == null)
                return "";
            else {
                var arr = new string[] { co.PorNameCn, co.PolNameCn ?? "N/A", co.PodNameCn ?? "N/A", co.DestNameCn };
                return string.Join("->", arr.Where(a=>!string.IsNullOrWhiteSpace(a)));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
