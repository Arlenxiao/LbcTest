namespace Lbc.WebApi.Modes {

    using System.Collections.Generic;

    /// <summary>
    /// 委托费用
    /// </summary>
    public class ConsignCostsDto {
        /// <summary>
        /// 
        /// </summary>
        public ConsignCostsDto() {
            this.Costs = new List<ConsignCostDto>();
            this.CurrencyCosts = new List<CurrencyCostDto>();
        }

        /// <summary>
        /// 参考利润
        /// </summary>
        public IEnumerable<CurrencyCostDto> CurrencyCosts {
            get;
            set;
        }

        /// <summary>
        /// 费用列表
        /// </summary>
        public IEnumerable<ConsignCostDto> Costs {
            get;
            set;
        }
    }

    public class CurrencyCostDto {
        public string Currency {
            get;
            set;
        }

        public int Type {
            get;
            set;
        }

        public decimal Amount {
            get;
            set;
        }
    }
}


