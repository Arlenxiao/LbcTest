using System.Collections.Generic;

namespace Lbc.WebApi.Modes {
    /// <summary>
    /// 委托箱需求
    /// </summary>
    public class ConsignContainerGoodsDto {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ConsignContainerGoodsDto() {
            this.Goodses = new List<ConsignGoodsDto>();
        }

        /// <summary>
        /// 20尺平柜数
        /// </summary>
        public int? Gp20 {
            get;
            set;
        }

        /// <summary>
        /// 40尺平柜数
        /// </summary>
        public int? Gp40 {
            get;
            set;
        }

        /// <summary>
        /// 40尺高柜数
        /// </summary>
        public int? Hq40 {
            get;
            set;
        }

        /// <summary>
        /// 45尺高柜数
        /// </summary>
        public int? Hq45 {
            get;
            set;
        }

        /// <summary>
        /// 特殊箱型
        /// </summary>
        public string SpecialSizetype {
            get;
            set;
        }

        /// <summary>
        /// 特殊箱型数
        /// </summary>
        public int? SpecialSizetypeQty {
            get;
            set;
        }


        /// <summary>
        /// 货物信息
        /// </summary>
        public IEnumerable<ConsignGoodsDto> Goodses {
            get;
            set;
        }
    }
}
