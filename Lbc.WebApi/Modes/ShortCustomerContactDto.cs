
namespace Lbc.WebApi.Modes {

    /// <summary>
    /// 客户联系人
    /// </summary>
    public class ShortCustomerContactDto {

        /// <summary>
        /// 客户流水号
        /// </summary>
        public decimal CustomerId {
            get;
            set;
        }


        /// <summary>
        /// 货代客户联系人流水号
        /// </summary>
        public decimal CustomerContactsId {
            get;
            set;
        }


        /// <summary>
        /// 客户企业联系人类型0111:业务联系人112:操作联系人113:销售联系人118:财务联系人119:其它联系人
        /// </summary>
        public int ContactsType {
            get;
            set;
        }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string Fullname {
            get;
            set;
        }

        /// <summary>
        /// F:Female  女M:Male 男
        /// </summary>
        public string Gender {
            get;
            set;
        }

        /// <summary>
        // 部门
        /// </summary>
        public string Dept {
            get;
            set;
        }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string Tel {
            get;
            set;
        }

        /// <summary>
        /// 手机
        /// </summary>
        public string Mobile {
            get;
            set;
        }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address {
            get;
            set;
        }

        /// <summary>
        /// 状态:-10-历史数据-1-关系删除0-1-关系可用
        /// </summary>
        public int Status {
            get;
            set;
        }

    }
}


