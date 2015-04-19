using Lbc.WebApi;
using Lbc.WebApi.Methods;
using Lbc.WebApi.Modes;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lbc.Pages {

    [ImplementPropertyChanged]
    public partial class OrderListPage : ContentPage/*INotifyPropertyChanged*/ {

        //public event PropertyChangedEventHandler PropertyChanged;

        //private ObservableCollection<ShortConsignDto> datas = null;
        //public ObservableCollection<ShortConsignDto> Datas {
        //    get {
        //        return this.datas;
        //    }
        //    set {
        //        this.datas = value;
        //        this.NotifyPropertyChanged("Datas");
        //    }
        //}

        public ObservableCollection<ShortConsignDto> Datas {
            get;
            set;
        }

        public OrderListPage() {
            InitializeComponent();
            this.Appearing += OrderListPage_Appearing;

            this.BindingContext = this;
        }

        void OrderListPage_Appearing(object sender, EventArgs e) {
            this.LoadConsigns();
        }

        public async void LoadConsigns() {
            var method = new GetConsignList() {
                PageSize = 20
            };
            var datas = await ApiClient.Execute(method);
            if (datas != null) {
                this.Datas = new ObservableCollection<ShortConsignDto>(datas.Items);
            }
        }

        //private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
        //    if (this.PropertyChanged != null) {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
