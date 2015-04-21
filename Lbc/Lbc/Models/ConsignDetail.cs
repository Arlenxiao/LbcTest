using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbc.Models {
    public class ConsignDetail {
        public string Group {
            get;
            set;
        }

        public string Key {
            get;
            set;
        }

        public string Value {
            get;
            set;
        }

        public ConsignDetail(string group, string key, string value) {
            this.Group = group;
            this.Key = key;
            this.Value = value;
        }
    }
}
