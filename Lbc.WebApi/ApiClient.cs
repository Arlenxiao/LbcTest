using Lbc.WebApi.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbc.WebApi {
    public class ApiClient {
        public static readonly string BaseUrl = "http://api.lbc.56cargo.com/api/v1/framework";


        private static string Token {
            get;
            set;
        }

        public static void SetToken(string token) {
            Token = token;
        }

        public static string GetMethodUrl(string methodName) {
            return string.Format("{0}/{1}", BaseUrl, methodName);
        }

        public async static Task<T> Execute<T>(MethodBase<T> method) {
            return await method.Execute(Token);
        }

    }
}
