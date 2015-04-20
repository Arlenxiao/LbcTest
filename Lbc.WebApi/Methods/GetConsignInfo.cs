using Lbc.WebApi.Attributes;
using Lbc.WebApi.Modes;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lbc.WebApi.Methods {
    public class GetConsignInfo : MethodBase<ConsignDto> {
        public override string MethodName {
            get {
                return "consign/GetConsignInfo";
            }
        }

        [Param]
        public decimal ConsignID {
            get;
            set;
        }

        internal override Func<HttpClient, Uri, Task<HttpResponseMessage>> Invoke {
            get {
                return (client, uri) => client.GetAsync(this.BuildUrl(uri));
            }
        }
    }
}
