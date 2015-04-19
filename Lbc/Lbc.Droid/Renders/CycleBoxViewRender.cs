using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Xamarin.Forms;
using Lbc.Droid.Renders;
using Lbc.Controls;

[assembly: ExportRenderer(typeof(CycleBoxView), typeof(CycleBoxViewRender))]
namespace Lbc.Droid.Renders {
    public class CycleBoxViewRender : BoxRenderer {

        public override void SetBackgroundColor(Android.Graphics.Color color) {
            base.SetBackgroundColor(Android.Graphics.Color.Transparent);//Always Transparent
        }

        protected override void OnDraw(Canvas canvas) {
            try {
                var radius = Math.Min(Width, Height) / 2;
                using (var paint1 = new Paint())
                using (var paint2 = new Paint()) {

                    paint1.Color = Android.Graphics.Color.Transparent;
                    canvas.DrawRect(0, 0, this.Width, this.Height, paint1);

                    paint2.Color = this.Element.Color.ToAndroid();
                    canvas.DrawCircle(Width / 2, Height / 2, radius, paint2);
                }
            } catch {
                //Debug.WriteLine("Unable to create circle image: " + ex);
            }

            base.OnDraw(canvas);
        }

        
    }
}