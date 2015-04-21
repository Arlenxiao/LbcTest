
using Lbc.Models;
using Lbc.WebApi;
using Lbc.WebApi.Methods;
using Lbc.WebApi.Modes;
using PropertyChanged;
using Xamarin.Forms;
using System.Collections.Generic;
using Lbc;

namespace Lbc.Pages {

    [ImplementPropertyChanged]
    public partial class CosignDetail : ContentPage {

        private decimal ID;

        public ConsignDto Data {
            get;
            set;
        }

        public IEnumerable<ConsignDetail> Details {
            get;
            set;
        }

        public bool NeedShowBusy {
            get;
            set;
        }

        public CosignDetail(decimal id) {
            InitializeComponent();
            this.ID = id;
            this.BindingContext = this;

            this.LoadData();
        }

        public async void LoadData() {
            this.NeedShowBusy = true;
            var method = new GetConsignInfo() {
                ConsignID = this.ID
            };

            var data = await ApiClient.Execute(method);
            this.NeedShowBusy = false;
            if (data != null) {
                this.Data = data;
                this.Details = data.Convert();
            }
        }
    }
}
