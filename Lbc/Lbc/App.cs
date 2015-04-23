using Lbc.Pages;
using Lbc.WebApi;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lbc {
    public partial class App : Application {
        public App() {

            this.InitializeComponent();

            ApiClient.OnMethodExecuted += ApiClient_OnMethodExecuted;

            this.MainPage = new NavigationPage(new MainPage());
            this.ModalPopping += App_ModalPopping;
        }

        void ApiClient_OnMethodExecuted(object sender, ApiExecutedEventArgs e) {
            if (e.StatusCode == HttpStatusCode.Unauthorized) {
                if (!((NavigationPage)this.MainPage).CurrentPage.GetType().Equals(typeof(LoginPage))) {
                    Device.BeginInvokeOnMainThread(() => {
                        this.MainPage.Navigation.PushModalAsync(new LoginPage());
                    });
                }
            }
        }

        void App_ModalPopping(object sender, ModalPoppingEventArgs e) {

        }

        protected override void OnStart() {
            //this.CheckLogin();
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            //this.CheckLogin();
        }

        //private void CheckLogin() {
        //    var token = PropertiesHelper.GetToken();
        //    if (!token.IsLogined || token.IsExpressed)
        //        this.MainPage.Navigation.PushModalAsync(new LoginPage());
        //}
    }
}
