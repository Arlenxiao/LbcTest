using System.Collections.Generic;
namespace Lbc.WebApi.Modes {

    /// <summary>
    /// 委托报关 
    /// </summary>
    public class ConsignCustomsDto {
        public ConsignCustomsDto() {
            this.Factories = new List<ConsignFactoryDto>();
        }

        /// <summary>
        /// 补料状态（提单还柜完成后~截关当天(不申报特殊材料)/提前24小时(需申报特殊材料)）
        ///0:未补料
        ///1:已补料
        /// </summary>
        //public int? Si { get; set; }

        /// <summary>
        /// 业务-报关
        ///0:否
        /// </summary>
        public bool IsCustoms {
            get;
            set;
        }

        /// <summary>
        /// 报关类型(1-买单报关	2-自备材料报关  必填项)
        /// </summary>
        public int CustomsType {
            get;
            set;
        }

        /// <summary>
        /// S/O号码
        /// </summary>
        public string SoNo {
            get;
            set;
        }



        /// <summary>
        /// 报关类型
        /// </summary>
        public int? DcType {
            get;
            set;
        }

        /// <summary>
        /// 是否商检
        /// </summary>
        public int? Ic {
            get;
            set;
        }

        /// <summary>
        /// 是否委托拖车
        /// </summary>
        public bool? IsTruck {
            get;
            set;
        }

        ///// <summary>
        ///// 工厂列表(拖车列表)
        ///// </summary>
        //public ConsignFactoriesDto ConsignFactories { get; set; }


        /// <summary>
        /// 工厂列表
        /// </summary>
        public IEnumerable<ConsignFactoryDto> Factories {
            get;
            set;
        }

        /// <summary>
        /// 是否涉及报检状态
        /// </summary>
        //public int? Ic { get; set; }


        /// <summary>
        /// 是否退税核销
        /// </summary>
        //public bool? Drawback { get; set; }


        /// <summary>
        /// 核销单名称/号码
        /// </summary>
        //[StringLength(30)]
        //public string Verification { get; set; }

    }
}


