using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbc.WebApi.Attributes {
    public class DescriptionAttribute : Attribute {

        public string Desc {
            get;
            set;
        }

        public DescriptionAttribute(string desc) {
            this.Desc = desc;
        }

    }
}
