using Lbc.Controls;
using Lbc.WinPhone.Renders;
using System;
using System.Windows.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly:ExportRenderer(typeof(CycleImage), typeof(CycleImageRender))]
namespace Lbc.WinPhone.Renders {
    public class CycleImageRender : ImageRenderer {

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            base.OnElementPropertyChanged(sender, e);

            if (Control != null && Control.Clip == null) {
                var min = Math.Min(Element.WidthRequest, Element.HeightRequest) / 2.0f;
                if (min <= 0)
                    return;

                Control.Clip = new EllipseGeometry {
                    Center = new System.Windows.Point(min, min),
                    RadiusX = min,
                    RadiusY = min
                };
            }
        }

    }
}
