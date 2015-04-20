namespace Lbc.WebApi.Modes {
    using System.Collections.Generic;

    /// <summary>
    /// 委托委托人信息
    /// </summary>
    public class ConsignConsignerDto
    {
        public ConsignConsignerDto()
        {
            this.ConsignContacts = new List<ShortCustomerContactDto>();
        }
        /// <summary>
        /// 委托人流水号
        /// </summary>
        public decimal ConsignerId { get; set; }

        /// <summary>
        /// 委托人电话
        /// </summary>
        public string ConsignerShortName { get; set; }

        /// <summary>
        /// 委托人简称
        /// </summary>
        public string ConsignerNameCn { get; set; }

        /// <summary>
        /// 委托人简称
        /// </summary>
        public string ConsignerNameEn { get; set; }

        /// <summary>
        /// 委托人电话
        /// </summary>
        public string ConsignerTel { get; set; }

        /// <summary>
        /// 中文地址
        /// </summary>
        public string ConsignerAddressCn { get; set; }

        /// <summary>
        /// 英文地址
        /// </summary>
        public string ConsignerAddressEn { get; set; }


        /// <summary>
        /// 委托联系人
        /// </summary>
        public IEnumerable<ShortCustomerContactDto> ConsignContacts { get; set; }
    }
}


