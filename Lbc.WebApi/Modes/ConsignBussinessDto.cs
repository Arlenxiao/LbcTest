namespace Lbc.WebApi.Modes {

    using System;

    /// <summary>
    /// 委托业务资料传输对象
    /// </summary>
    public class ConsignBussinessDto {
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
        /// 发货人描述
        /// </summary>
        public string ConsignorDesc {
            get;
            set;
        }

        /// <summary>
        /// 收货人ID
        /// </summary>
        public decimal? ConsigneeId {
            get;
            set;
        }

        /// <summary>
        /// 收货人名称(如果是个人时保存收货人护照号码)
        /// </summary>
        public string ConsigneeName {
            get;
            set;
        }

        /// <summary>
        /// 收货人描述
        /// </summary>
        public string ConsigneeDesc {
            get;
            set;
        }

        /// <summary>
        /// 通知人ID
        /// </summary>
        public decimal? NotifyId {
            get;
            set;
        }

        /// <summary>
        /// 通知人名称
        /// </summary>
        public string NotifyName {
            get;
            set;
        }

        /// <summary>
        /// 通知人描述
        /// </summary>
        public string NotifyDesc {
            get;
            set;
        }


        /// <summary>
        /// 运输条款
        ///1:CY-CY
        ///2:CY-DOOR
        ///3:CFS-CY
        ///4:CFS-CFS
        ///5:CFS-DOOR
        ///6:DOOR-DOOR
        ///7:DOOR-CY
        ///8:CY-FIO
        ///9:CY-CFS
        ///10:CY-HOOK
        ///11:CY-LO
        ///12:CY-FO
        /// </summary>
        public int TransType {
            get;
            set;
        }

        /// <summary>
        /// 运输条款名称
        /// </summary>
        public string TransTypeName {
            get;
            set;
        }

        /// <summary>
        /// 贸易条款
        /// </summary>
        public int TradeType {
            get;
            set;
        }

        /// <summary>
        /// 贸易条款名称
        /// </summary>
        public string TradeTypeName {
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


        /// <summary>
        /// 揽货类型
        ///0
        ///11自揽货
        ///12自揽同行货
        ///21公司货
        ///22公司同行货
        ///25公司合约货
        ///31船公司指定货
        ///32客户指定货
        /// </summary>
        public int? Salestype {
            get;
            set;
        }


        /// <summary>
        /// 委托方式
        ///0现场
        ///1电话
        ///2传真
        ///3邮件
        ///4Web
        ///5手机
        ///6微信
        ///7
        ///8接口
        ///9其它
        /// </summary>
        public int? ConsignMode {
            get;
            set;
        }

        /// <summary>
        /// 订舱名义
        /// </summary>
        public decimal? BookingbyId {
            get;
            set;
        }

        /// <summary>
        /// 订舱名义名称
        /// </summary>
        public string BookingbyName {
            get;
            set;
        }

        /// <summary>
        /// 合约号
        /// </summary>
        public string ContractNo {
            get;
            set;
        }

        /// <summary>
        /// 目的港代理（合作商）
        /// </summary>
        public decimal? PartnersId {
            get;
            set;
        }

        /// <summary>
        /// 目的港代理（合作商）
        /// </summary>
        public string PartnersName {
            get;
            set;
        }

        /// <summary>
        /// 可以转船
        /// </summary>
        public bool? AllowTranshipment {
            get;
            set;
        }

        /// <summary>
        /// 可以分批
        /// </summary>
        public bool? AllowBatch {
            get;
            set;
        }
    }
}
