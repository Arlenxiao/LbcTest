using System.Collections.Generic;
using System.Linq;

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

        public string ContaDesc {
            get {
                var dic = new Dictionary<string, int?>() {
                    {"20GP", this.Gp20},
                    {"40GP", this.Gp40},
                    {"40HQ", this.Hq40},
                    {"45HQ", this.Hq45},
                };

                return string.Join(";", dic.Where(kv => kv.Value.HasValue && kv.Value > 0)
                    .Select(kv => string.Format("{0}x{1}", kv.Value, kv.Key)));
            }
        }

        public IEnumerable<string> GoodsDescs {
            get {
                return this.Goodses.Select(g => string.Format("{0} ({1} {2})", g.GoodsDesc, g.Qty, g.QtyUnit));
            }
        }
    }
}
