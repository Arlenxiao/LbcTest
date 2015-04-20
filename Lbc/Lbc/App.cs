using Lbc.Pages;
using Xamarin.Forms;

namespace Lbc {
    public partial class App : Application {
        public App() {

            this.InitializeComponent();

            this.MainPage = new NavigationPage(new MainPage());
            this.ModalPopping += App_ModalPopping;
        }

        void App_ModalPopping(object sender, ModalPoppingEventArgs e) {

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
            var token = TokenHelper.GetToken();
            if (!token.IsLogined || token.IsExpressed)
                this.MainPage.Navigation.PushModalAsync(new LoginPage());
        }
    }
}
