using System.Net.Http;

namespace Lbc.WebApi {
    public class OAuthHttpClient : HttpClient {

        public OAuthHttpClient(string token)
            : base(new OAuthMessageHandler(token)) {
        }
    }
}
