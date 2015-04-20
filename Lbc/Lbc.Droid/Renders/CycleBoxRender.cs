
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Lbc.Controls;
using Lbc.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CycleBox), typeof(CycleBoxRender))]
namespace Lbc.Droid.Renders {
    public class CycleBoxRender : VisualElementRenderer<CycleBox> {

        protected override void OnElementChanged(ElementChangedEventArgs<CycleBox> e) {
            base.OnElementChanged(e);
            this.UpdateBackground();

            this.Element.HorizontalOptions = LayoutOptions.Center;
            this.Element.VerticalOptions = LayoutOptions.Center;

            var w = this.Element.Radius * 1.5;
            this.Element.WidthRequest = w;
            this.Element.HeightRequest = w;
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            base.OnElementPropertyChanged(sender, e);

            this.UpdateBackground();
        }

        private void UpdateBackground() {
            //var dab = new GradientDrawable();
            //dab.SetColor(this.Element.BackgroundColor.ToAndroid());
            //dab.SetCornerRadius((float)this.Element.Radius);
            //this.ViewGroup.SetBackgroundDrawable(dab);

            var shape = new OvalShape();
            var da = new ShapeDrawable(shape);
            da.Paint.Color = this.Element.BackgroundColor.ToAndroid();
            this.ViewGroup.SetBackgroundDrawable(da);
        }

    }
}