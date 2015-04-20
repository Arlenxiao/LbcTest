namespace Lbc.WebApi.Modes {

    using System;

    /// <summary>
    /// 委托工厂
    /// </summary>
    public class ConsignFactoryDto
    {
        public decimal ConsignFactoryId { get; set; }

        
        /// <summary>
        /// 工厂ID，Firm_Customer_ID
        /// </summary>
        public decimal FactoryId { get; set; }

        /// <summary>
        /// 公司名称中文，Customer_Name_CN
        /// </summary>
        public string FactoryNameCn { get; set; }

        /// <summary>
        /// 公司名称英文，Customer_Name_EN
        /// </summary>
        public string FactoryNameEn { get; set; }

        /// <summary>
        /// 公司简称，Customer_ShortName
        /// </summary>
        public string FactoryShortname { get; set; }

        /// <summary>
        /// 公司地址英文
        /// </summary>
        public string AddressEn { get; set; }

        /// <summary>
        /// 公司地址中文
        /// </summary>
        public string AddressCn { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public decimal? ContactsId { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string ContactsName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public string ContactsTel { get; set; }

        /// <summary>
        /// 装柜时间
        /// </summary>
        public DateTime? LoadTime { get; set; }

        /// <summary>
        /// 箱数
        /// </summary>
        public decimal ContainerQty { get; set; }

        /// <summary>
        /// 柜型
        /// </summary>
        public string ContainerType { get; set; }

    }
}


