﻿
using Lbc.WebApi.Attributes;
using Lbc.WebApi.Modes;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lbc.WebApi.Methods {
    public class GetConsignList : MethodBase<PagedResult<ShortConsignDto>> {
        public override string MethodName {
            get {
                return "Consign/GetConsignList";
            }
        }

        [Param]
        public int PageIndex {
            get;
            set;
        }

        [Param]
        public int PageSize {
            get;
            set;
        }

        [Param(Required = false)]
        public string NameOrNo {
            get;
            set;
        }


        internal override Func<HttpClient, Uri, Task<HttpResponseMessage>> Invoke {
            get {
                return (client, url) => client.GetAsync(this.BuildUrl(url));
            }
        }
    }
}
