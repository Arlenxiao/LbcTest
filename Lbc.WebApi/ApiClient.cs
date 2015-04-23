using System;
using System.Threading.Tasks;

namespace Lbc.WebApi {
    public class ApiClient {
        public static readonly string BaseUrl = "http://localhost:10687/api/v1/framework";

        public static event EventHandler<ApiExecutedEventArgs> OnMethodExecuted;

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
            return await method.Execute(Token)
                .ContinueWith(t => {

                    if (OnMethodExecuted != null) {
                        OnMethodExecuted.Invoke(null, new ApiExecutedEventArgs() {
                            ErrorResion = method.ErrorReason,
                            StatusCode = method.Status,
                            HasError = method.HasError
                        });
                    }

                    return t.Result;
                });
        }
    }
}
