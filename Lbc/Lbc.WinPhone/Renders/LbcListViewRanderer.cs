using Lbc.WinPhone.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

//[assembly: ExportRenderer(typeof(ListView), typeof(LbcListViewRanderer))]
namespace Lbc.WinPhone.Resources {
    public class LbcListViewRanderer : ListViewRenderer {

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e) {
            base.OnElementChanged(e);

            //if (e.OldElement == null) {

            //}

            Element.SeparatorColor = Color.Green;
            Element.SeparatorVisibility = SeparatorVisibility.Default;
        }

    }
}
