using Lbc.Pages;
using Lbc.WebApi;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lbc {
    public partial class App : Application {
        public App() {
            this.InitApiClient();
            this.InitializeComponent();
            this.MainPage = new NavigationPage(new MainPage());
        }

        private void InitApiClient() {
            var token = PropertiesHelper.GetToken();
            ApiClient.SetToken(token.AccessToken);
            ApiClient.OnMethodExecuted += ApiClient_OnMethodExecuted;
        }

        void ApiClient_OnMethodExecuted(object sender, ApiExecutedEventArgs e) {
            if (e.StatusCode.HasValue) {

                switch (e.StatusCode.Value) {
                    case HttpStatusCode.OK:
                        //Do nothing
                        break;
                    case HttpStatusCode.NotFound:
                        Device.BeginInvokeOnMainThread(() =>
                            this.MainPage.DisplayAlert("网络错误", "暂时无法连接到服务器；请检查网络是否连接正常。稍后重试。", "OK"));
                        break;
                    case HttpStatusCode.Unauthorized:
                        //未认证时，跳转到登陆页面
                        this.ShowLogin();
                        break;
                    case HttpStatusCode.InternalServerError:
                    case HttpStatusCode.ServiceUnavailable:
                        Device.BeginInvokeOnMainThread(() => this.MainPage.DisplayAlert("抱歉", "服务暂时不可用，请稍后重试。", "OK"));
                        break;
                    default:
                        Device.BeginInvokeOnMainThread(() => this.MainPage.DisplayAlert("未知错误", "发生了未知错误。", "OK"));
                        break;
                }
            }
        }

        private void ShowLogin() {
            if (!((NavigationPage)this.MainPage).CurrentPage.GetType().Equals(typeof(LoginPage))) {
                Device.BeginInvokeOnMainThread(() => {
                    this.MainPage.Navigation.PushModalAsync(new LoginPage());
                });
            }
        }

        protected override void OnStart() {
            this.CheckLogin();
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            this.CheckLogin();
        }

        private void CheckLogin() {
            var token = PropertiesHelper.GetToken();
            if (!token.IsLogined || !token.IsValid)
                this.ShowLogin();
        }
    }
}
