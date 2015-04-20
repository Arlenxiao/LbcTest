using System;
namespace Lbc.WebApi.Modes {

    /// <summary>
    /// 委托船期
    /// </summary>
    public class ConsignScheduleDto {
        /// <summary>
        /// 委托船期流水号
        /// </summary>
        public decimal ConsignScheduleId {
            get;
            set;
        }

        /// <summary>
        /// 船期类型
        ///1:前程支线(头程)
        ///2:大船(二程)
        ///3:主线中转
        ///4:后程支线
        ///5:建议
        ///9:其它
        /// </summary>
        //[Required]
        //public decimal ScheduleType { get; set; }

        ///// <summary>
        ///// 承运人流水号
        ///// </summary>
        //[Required]
        //public decimal CarrierId { get; set; }

        ///// <summary>
        ///// 承运人名称
        ///// </summary>
        //[Required]
        //[StringLength(35)]
        //public string CarrierName { get; set; }

        /// <summary>
        /// 船期流水号
        /// </summary>
        public decimal ScheduleId {
            get;
            set;
        }

        /// <summary>
        /// 船舶名称
        /// </summary>
        public string Vessel {
            get;
            set;
        }

        /// <summary>
        /// 航次
        /// </summary>
        public string Voyage {
            get;
            set;
        }

        /// <summary>
        /// 开船时间(Etd)
        /// </summary>
        public DateTime? Etd {
            get;
            set;
        }

        /// <summary>
        /// 截关时间（CLS）
        /// </summary>
        public DateTime? Cls {
            get;
            set;
        }

        /// <summary>
        /// 状态:
        ///-10-历史数据
        ///-1-关系删除
        ///0-
        ///1-关系可用
        /// </summary>
        public decimal Status {
            get;
            set;
        }

    }
}


