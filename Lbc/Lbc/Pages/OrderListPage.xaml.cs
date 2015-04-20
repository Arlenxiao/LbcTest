using Lbc.WebApi;
using Lbc.WebApi.Methods;
using Lbc.WebApi.Modes;
using PropertyChanged;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Lbc.Pages {

    [ImplementPropertyChanged]
    public partial class OrderListPage : ContentPage/*INotifyPropertyChanged*/ {

        /// <summary>
        /// 当前页数
        /// </summary>
        private int PageIdx = 0;

        /// <summary>
        /// 数据集
        /// </summary>
        public ObservableCollection<ShortConsignDto> Datas {
            get;
            set;
        }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        public string Keyword {
            get;
            set;
        }

        public bool NeedShowBusy {
            get;
            set;
        }


        public OrderListPage() {
            InitializeComponent();
            this.Appearing += OrderListPage_Appearing;

            this.BindingContext = this;
        }


        /// <summary>
        /// 下拉刷新事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshData(object sender, EventArgs e) {
            this.PageIdx = 0;
            this.LoadConsigns(true);
            var lst = (ListView)sender;
            lst.IsRefreshing = false;
        }

        /// <summary>
        /// 选中某行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowDetail(object sender, SelectedItemChangedEventArgs e) {
            var id = ((ShortConsignDto)e.SelectedItem).ConsignId;
            var detail = new CosignDetail(id);

            Application.Current.MainPage.Navigation.PushAsync(detail);
            //Navigation.PushAsync(detail);
        }

        /// <summary>
        /// 加载更多按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LoadMore(object sender, EventArgs e) {
            this.LoadConsigns();
        }

        void OrderListPage_Appearing(object sender, EventArgs e) {
            if (this.Datas == null)
                this.LoadConsigns();
        }

        /// <summary>
        /// 搜索框事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Search(object sender, EventArgs e) {
            this.LoadConsigns(true);
        }

        /// <summary>
        /// 搜索框文本变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SearchKeyChanged(object sender, EventArgs e) {
            this.PageIdx = 0;
        }

        public async void LoadConsigns(bool isRefresh = false) {
            this.NeedShowBusy = true;
            var method = new GetConsignList() {
                PageIndex = this.PageIdx,
                PageSize = 20,
                NameOrNo = (Keyword ?? "").Trim()//nameOrNo
            };
            var datas = await ApiClient.Execute(method);
            this.NeedShowBusy = false;
            if (datas != null) {
                if (this.Datas == null || isRefresh)
                    this.Datas = new ObservableCollection<ShortConsignDto>(datas.Items);
                else
                    foreach (var d in datas.Items) {
                        this.Datas.Add(d);
                    }

                if (datas.Items.Count > 0)
                    this.PageIdx++;
            }
        }
    }
}
