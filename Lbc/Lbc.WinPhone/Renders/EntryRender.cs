using Lbc.WinPhone.Renders;
using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryRender))]
namespace Lbc.WinPhone.Renders {

    public class EntryRender : EntryRenderer {

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e) {
            base.OnElementChanged(e);

            foreach (var chd in this.Control.Children) {
                ((System.Windows.Controls.Control)chd).Background = this.Element.BackgroundColor.ToBrush();
                ((System.Windows.Controls.Control)chd).Margin = new System.Windows.Thickness(-10,-15,-10,-15);
            }
        }

        protected override void UpdateBackgroundColor() {
            this.Control.Background = new SolidColorBrush(System.Windows.Media.Colors.Transparent);
        }

    }
}
