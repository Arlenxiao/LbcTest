using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
