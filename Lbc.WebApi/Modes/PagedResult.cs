﻿using System.Collections.Generic;

namespace Lbc.WebApi.Modes {
    public class PagedResult<T> {

        public int TotalCount {
            get;
            set;
        }

        public List<T> Items {
            get;
            set;
        }

    }
}
