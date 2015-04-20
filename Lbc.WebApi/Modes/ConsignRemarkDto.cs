namespace Lbc.WebApi.Modes {
    using System;

    /// <summary>
    /// 委托备注
    /// </summary>
    public class ConsignRemarkDto {
        /// <summary>
        /// 委托备注流水号
        /// </summary>
        public decimal ConsignRemarkId {
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
        /// 备注类型
        ///1:询价人备注
        ///2:委托人备注
        ///3:业务员(揽货人)备注
        ///4:商务审核备注
        ///5:订舱人备注
        ///6:客服备注
        ///7:
        ///8:放货审批人备注
        ///9:放货复审人备注
        ///10:其它备注
        /// </summary>
        public int RemarkType {
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

        /// <summary>
        /// 创建人ID
        /// </summary>
        public decimal CreateId {
            get;
            set;
        }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreateName {
            get;
            set;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate {
            get;
            set;
        }

    }
}


