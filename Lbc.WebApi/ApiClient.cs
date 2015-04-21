using System.Threading.Tasks;

namespace Lbc.WebApi {
    public class ApiClient {
        public static readonly string BaseUrl = "http://192.168.0.50:8001/api/v1/framework";


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
