using Newtonsoft.Json;
using System;

namespace Lbc.WebApi.Modes {
    public class ShortConsignDto {
        /// <summary>
        /// 委托业务流水号
        /// </summary>
        public decimal ConsignId {
            get;
            set;
        }


        /// <summary>
        /// 委托人 
        /// </summary>
        public string ConsignerName {
            get;
            set;
        }


        /// <summary>
        /// 所属货代企业流水号,当值为0时所有企业可用
        /// </summary>
        public decimal FfId {
            get;
            set;
        }


        /// <summary>
        /// 业务委托号
        /// </summary>
        public string ConsignNo {
            get;
            set;
        }

        /// <summary>
        /// 委托日期
        /// </summary>
        public DateTime? ConsignDate {
            get;
            set;
        }

        public decimal Status {
            get;
            set;
        }

        public ConsignStatus StatusEnum {
            get {
                return (ConsignStatus)Status;
            }
        }

        /// <summary>
        /// 发货人ID
        /// </summary>
        public decimal? ConsignorId {
            get;
            set;
        }

        /// <summary>
        /// 发货人名称
        /// </summary>
        public string ConsignorName {
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
        /// 目的地名称Destination  
        /// </summary>
        public string DestNameEn {
            get;
            set;
        }

        /// <summary>
        /// 目的地中文名称Destination  
        /// </summary>
        public string DestNameCn {
            get;
            set;
        }

        /// <summary>
        /// 收货地名称Place Of Receipt  
        /// </summary>
        public string PorNameEn {
            get;
            set;
        }

        /// <summary>
        /// 收货地中文名称Place Of Receipt  
        /// </summary>
        public string PorNameCn {
            get;
            set;
        }

    }
}
