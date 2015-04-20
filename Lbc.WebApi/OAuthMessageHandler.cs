using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

namespace Lbc.WebApi {
    public class OAuthMessageHandler : MessageProcessingHandler {

        private string Token;

        public OAuthMessageHandler(string token)
            : base(new HttpClientHandler()) {
            this.Token = token;
        }

        protected override HttpRequestMessage ProcessRequest(HttpRequestMessage request, CancellationToken cancellationToken) {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", this.Token);
            return request;
        }

        protected override HttpResponseMessage ProcessResponse(HttpResponseMessage response, CancellationToken cancellationToken) {
            return response;
        }
    }
}
