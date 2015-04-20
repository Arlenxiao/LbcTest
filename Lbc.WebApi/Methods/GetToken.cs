using Lbc.WebApi.Attributes;
using Lbc.WebApi.Modes;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lbc.WebApi.Methods {
    public class GetToken : MethodBase<Token> {

        public override string MethodName {
            get {
                return "token";
            }
        }

        [Param]
        public string UserName {
            get;
            set;
        }

        [Param]
        public string Password {
            get;
            set;
        }

        [Param("grant_type")]
        public string GrantType {
            get {
                return "password";
            }
        }

        internal override Func<HttpClient, Uri, Task<HttpResponseMessage>> Invoke {
            get {
                return (client, url) => client.PostAsync(url, this.GetStringContent());
            }
        }
    }
}
