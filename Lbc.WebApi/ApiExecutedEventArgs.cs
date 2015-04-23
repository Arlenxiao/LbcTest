using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lbc.WebApi {
    public class ApiExecutedEventArgs : EventArgs {

        public HttpStatusCode? StatusCode {
            get;
            set;
        }

        public bool HasError {
            get;
            set;
        }

        public string ErrorResion {
            get;
            set;
        }

    }
}
