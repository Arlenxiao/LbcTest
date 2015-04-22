using System.Collections.Generic;
using Xamarin.Forms;


namespace Lbc.Pages {
    public partial class MainPage : TabbedPage {

        public List<Page> Pages = new List<Page>() {
            new OrderListPage(),
            new CustomerListPage(),
            new TemplatesListPage(),
            new SettingPage()
        };

        public MainPage() {
            //InitializeComponent();
            //this.ItemsSource = this.Pages;
            this.BackgroundColor = Color.FromHex("DDDDDD");//在XAML中设置 Background 不起作用。

            this.Children.Add(new OrderListPage());
            this.Children.Add(new CustomerListPage());
            this.Children.Add(new TemplatesListPage());
            this.Children.Add(new SettingPage());
        }
    }
}
