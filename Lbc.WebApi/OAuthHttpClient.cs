using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lbc.WebApi {
    public class OAuthHttpClient : HttpClient {

        public OAuthHttpClient(string token)
            : base(new OAuthMessageHandler(token)) {
        }
    }
}
