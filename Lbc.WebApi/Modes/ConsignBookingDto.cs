namespace Lbc.WebApi.Modes {

    using System;

    /// <summary>
    /// 委托订舱信息
    /// </summary>
    public class ConsignBookingBLDto {
        /// <summary>
        /// 放舱单号S/O NO
        /// </summary>
        public string SoNo {
            get;
            set;
        }

        ///// <summary>
        ///// 订舱客户ID	默认与委托人相同，当贸易模式为FOB时，可指定为其它名义订舱  
        ///// </summary>
        //public decimal? BookingId { get; set; }

        ///// <summary>
        ///// 订舱客户名称  
        ///// </summary>
        //public string BookingName { get; set; }

        /// <summary>
        /// 订舱人ID
        /// </summary>
        public decimal? BookingUserId {
            get;
            set;
        }

        /// <summary>
        /// 订舱人名称
        /// </summary>
        public string BookingUserName {
            get;
            set;
        }

        /// <summary>
        /// 订舱方式
        /// </summary>
        public decimal? BookingMode {
            get;
            set;
        }

        /// <summary>
        /// 订舱操作时间
        /// </summary>
        public DateTime? BookingDate {
            get;
            set;
        }

        /// <summary>
        /// 放舱时间
        /// </summary>
        public DateTime? BookingSoDate {
            get;
            set;
        }


        /// <summary>
        /// 提单类型
        ///1:HOUSE B/L 货代提单
        ///2:OCEAN B/L 船东提单 
        ///3:TELEX RELEASE 电放提单
        ///4:SWB 水路提单
        /// </summary>
        public int? BillType {
            get;
            set;
        }


        /// <summary>
        /// 船东单号
        /// </summary>
        public string MblNo {
            get;
            set;
        }

        /// <summary>
        /// 船东电放单号
        /// </summary>
        public string MblTxNo {
            get;
            set;
        }


        /// <summary>
        /// 船东水路提单号
        /// </summary>
        public string MblSwbNo {
            get;
            set;
        }

        /// <summary>
        /// 船东单状态
        /// </summary>
        public string MblStatus {
            get;
            set;
        }

        /// <summary>
        /// 船东单数量
        /// </summary>
        public int? MblQty {
            get;
            set;
        }

        /// <summary>
        /// 提单号B/L NO或电放单号
        /// </summary>
        public string HblNo {
            get;
            set;
        }

        /// <summary>
        /// 电放单号
        /// </summary>
        public string HblTxNo {
            get;
            set;
        }


        /// <summary>
        /// 水路提单号
        /// </summary>
        public string HblSwbNo {
            get;
            set;
        }

        /// <summary>
        /// 提单状态
        /// </summary>
        public string HblStatus {
            get;
            set;
        }

        /// <summary>
        /// 提单数量
        /// </summary>
        public int? HblQty {
            get;
            set;
        }

    }
}


