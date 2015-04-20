﻿using Lbc.WebApi;
using Lbc.WebApi.Methods;
using PropertyChanged;
using System;
using Xamarin.Forms;

namespace Lbc.Pages {

    [ImplementPropertyChanged]
    public partial class LoginPage : ContentPage {

        public string Account {
            get;
            set;
        }

        public string Pwd {
            get;
            set;
        }

        public bool NeedShowBusy {
            get;
            set;
        }

        public LoginPage() {
            InitializeComponent();
            this.Account = "CSCL";
            this.Pwd = "CSCL";
            this.BindingContext = this;
        }

        public async void Login(object sender, EventArgs e) {
            this.NeedShowBusy = true;
            var method = new GetToken() {
                UserName = this.Account,
                Password = this.Pwd
            };
            var token = await ApiClient.Execute(method);
            this.NeedShowBusy = false;
            if (token == null || !token.IsLoginedSuccess) {
                await this.DisplayAlert("警告", "认证失败,请确认您的账户和密码是否正确", "OK");
            } else {
                token.LoginedOn = DateTime.Now;
                token.IsLogined = true;
                ApiClient.SetToken(token.AccessToken);
                TokenHelper.Save(token);
                await this.Navigation.PopModalAsync();
            }
        }
    }
}
