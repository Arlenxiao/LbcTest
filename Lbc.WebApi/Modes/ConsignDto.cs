using PropertyChanged;
using System;

namespace Lbc.WebApi.Modes {



    /// <summary>
    /// 委托单
    /// </summary>
    [ImplementPropertyChanged]
    public class ConsignDto {

        #region 委托单基本信息

        /// <summary>
        /// 委托业务流水号
        /// </summary>
        public decimal ConsignId {
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

        /// <summary>
        /// 状态:业务状态
        ///-10历史
        ///0:客户草稿
        ///5:客户提交
        ///10;(业务)草稿
        ///15:(业务)客户确认
        ///16:(业务)客户异议
        ///99:(业务)提交
        ///101:(商务)接单
        ///102:(商务)审核中
        ///104:(商务)审核拒绝
        ///109:(商务)审核通过
        ///201:(订舱)接单
        ///204:(订舱)订舱失败
        ///299:(订舱)订舱成功
        ///301:(操作)接单
        ///310:(操作)拖车/报关已安排
        ///320:(操作)还柜中（第1个柜进码头）
        ///329:(操作)已还柜（最后一个柜进码头）
        ///331:衬料操作
        ///350:已装船
        ///351:已收单(从船东或同行处取得提单)
        ///352:已出提单(MB/HB)
        ///353:电放
        ///501:扣单中
        ///511:未应收放单
        ///512:未应收电放
        ///521:已放单(应收已清)
        ///522:已电放(应收已清)
        ///699:财务完成(提成已出)
        ///999:已完成
        /// </summary>
        public int? Status {
            get;
            set;
        }

        public ConsignStatus? StatusEnum {
            get {
                if (this.Status != null)
                    return (ConsignStatus)Status;
                else
                    return null;
            }
        }

        /// <summary>
        /// 业务员ID
        /// </summary>
        public decimal? SalesId {
            get;
            set;
        }

        /// <summary>
        /// 业务员名称
        /// </summary>
        public string SalesName {
            get;
            set;
        }

        /// <summary>
        /// 业务部门
        /// </summary>
        public decimal? SalesDepartmentId {
            get;
            set;
        }

        /// <summary>
        /// 业务部门
        /// </summary>
        public string SalesDepartmentName {
            get;
            set;
        }

        /// <summary>
        /// 业务提交时间
        /// </summary>
        public DateTime? CommitDate {
            get;
            set;
        }


        /// <summary>
        /// 整拼箱
        /// </summary>
        public bool Lcl {
            get;
            set;
        }

        #endregion


        /// <summary>
        /// 委托人信息
        /// </summary>
        public ConsignConsignerDto ConsignConsigner {
            get;
            set;
        }


        /// <summary>
        /// 柜型柜量、货物信息
        /// </summary>
        public ConsignContainerGoodsDto ConsignContainerGoods {
            get;
            set;
        }


        /// <summary>
        /// 舱位信息(承运人信息)
        /// </summary>
        public ConsignCarrierDto ConsignCarrier {
            get;
            set;
        }


        /// <summary>
        /// 拖车(工厂)、报关信息
        /// </summary>
        public ConsignCustomsDto ConsignCustoms {
            get;
            set;
        }

        /// <summary>
        /// 费用信息
        /// </summary>
        public ConsignCostsDto ConsignCosts {
            get;
            set;
        }

        /// <summary>
        /// 订舱信息(S/O)
        /// </summary>
        public ConsignBookingBLDto ConsignBookingBL {
            get;
            set;
        }


        /// <summary>
        /// 委托业务资料
        /// </summary>
        public ConsignBussinessDto ConsignBussiness {
            get;
            set;
        }

        /// <summary>
        /// 备注信息
        /// </summary>
        public ConsignRemarksDto ConsignRemarks {
            get;
            set;
        }
    }
}


