namespace Lbc.WebApi.Modes {

    /// <summary>
    /// 舱位信息(承运人信息)
    /// </summary>
    public class ConsignCarrierDto {

        /// <summary>
        /// 承运人流水号（对应船东）
        /// </summary>
        public decimal? CarrierId {
            get;
            set;
        }

        /// <summary>
        /// 承运人名称
        /// </summary>
        public string CarrierName {
            get;
            set;
        }

        /// <summary>
        /// 承运人代码
        /// </summary>
        public string CarrierCode {
            get;
            set;
        }

        /// <summary>
        /// 同行货代ID（对应承运人）
        /// </summary>
        public decimal? FwdId {
            get;
            set;
        }

        /// <summary>
        /// 同行货代名称
        /// </summary>
        public string FwdName {
            get;
            set;
        }

        /// <summary>
        /// 业务-海运
        /// </summary>
        public bool? IsOcean {
            get;
            set;
        }

        /// <summary>
        /// 业务-拖车
        /// </summary>
        public bool? IsTruck {
            get;
            set;
        }

        /// <summary>
        /// 业务-报关
        /// </summary>
        public int IsCustoms {
            get;
            set;
        }


        /// <summary>
        /// 收货地代码
        /// </summary>
        public string OriginCode {
            get;
            set;
        }
        /// <summary>
        /// 收货地英文名称
        /// </summary>
        public string OriginNameEn {
            get;
            set;
        }

        /// <summary>
        // 收货地中文名称
        /// </summary>
        public string OriginNameCn {
            get;
            set;
        }


        /// <summary>
        /// 装货港代码
        /// </summary>
        public string PolCode {
            get;
            set;
        }
        /// <summary>
        /// 装货港英文名称
        /// </summary>
        public string PolNameEn {
            get;
            set;
        }

        /// <summary>
        /// 装货港中文名称
        /// </summary>
        public string PolNameCn {
            get;
            set;
        }


        /// <summary>
        /// 卸货港代码
        /// </summary>
        public string PodCode {
            get;
            set;
        }
        /// <summary>
        /// 卸货港英文名称
        /// </summary>
        public string PodNameEn {
            get;
            set;
        }

        /// <summary>
        /// 卸货港中文名称
        /// </summary>
        public string PodNameCn {
            get;
            set;
        }


        /// <summary>
        /// 目的地代码
        /// </summary>
        public string DestCode {
            get;
            set;
        }

        /// <summary>
        /// 目的地英文名称
        /// </summary>
        public string DestNameEn {
            get;
            set;
        }

        /// <summary>
        /// 目的地中文名称
        /// </summary>
        public string DestNameCn {
            get;
            set;
        }


        /// <summary>
        /// 船期
        /// </summary>
        public ConsignScheduleDto Schedule {
            get;
            set;
        }
    }
}


