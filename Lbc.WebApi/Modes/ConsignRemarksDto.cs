namespace Lbc.WebApi.Modes {
    using System.Collections.Generic;

    /// <summary>
    /// 委托备注
    /// </summary>
    public class ConsignRemarksDto
    {
        /// <summary>
        /// 
        /// </summary>
        public ConsignRemarksDto()
        {
            this.Remarks = new List<ConsignRemarkDto>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ConsignRemarkDto> Remarks { get; set; }

    }
}


