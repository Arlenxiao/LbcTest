using System;
using Xamarin.Forms;

namespace Lbc.Controls {
    public class CycleBox : ContentView {

        /// <summary>
        /// 半径
        /// </summary>
        public static readonly BindableProperty RadiusProperty =
            BindableProperty.Create<CycleBox, double>(c => c.Radius, 40);

        public double Radius {
            get {
                return (Double)base.GetValue(RadiusProperty);
            }
            set {
                base.SetValue(RadiusProperty, value);
            }
        }

    }
}
