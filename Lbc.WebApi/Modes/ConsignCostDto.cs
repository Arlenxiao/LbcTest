namespace Lbc.WebApi.Modes {

    /// <summary>
    /// 委托费用
    /// </summary>
    public class ConsignCostDto {
        /// <summary>
        /// 委托费用清单流水号
        /// </summary>
        public decimal ConsignCostId {
            get;
            set;
        }


        /// <summary>
        /// 委托业务流水号
        /// </summary>
        public decimal ConsignId {
            get;
            set;
        }

        /// <summary>
        /// 费用类型代码
        /// </summary>
        public string FeeCode {
            get;
            set;
        }

        /// <summary>
        /// 费用类型名称
        /// </summary>
        public string FeeName {
            get;
            set;
        }


        /// <summary>
        /// 支付类型0应收1应付
        /// </summary>
        public bool PaymentType {
            get;
            set;
        }


        /// <summary>
        /// 应收应付对象
        /// </summary>
        public string Payment {
            get;
            set;
        }


        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price {
            get;
            set;
        }

        /// <summary>
        /// 数量
        /// </summary>
        public int Qty {
            get;
            set;
        }

        /// <summary>
        /// 应收单位
        ///1按单(票)
        ///2按箱
        ///3箱尺寸（20尺或40尺）
        ///9按箱型（仅对应海运费）
        /// </summary>
        public decimal? UnitId {
            get;
            set;
        }

        /// <summary>
        /// 应收单位
        ///1按单(票)
        ///2按箱
        ///3箱尺寸（20尺或40尺）
        ///9按箱型（仅对应海运费）
        /// </summary>
        public string UnitName {
            get;
            set;
        }

        /// <summary>
        /// 币种
        /// </summary>
        public string Currency {
            get;
            set;
        }

        /// <summary>
        /// 应收类型
        ///PP:预付
        ///CC:到付
        /// </summary>
        public int? PPCC {
            get;
            set;
        }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal Cost {
            get;
            set;
        }


        /// <summary>
        /// 说明
        /// </summary>
        public string Remark {
            get;
            set;
        }

    }
}


