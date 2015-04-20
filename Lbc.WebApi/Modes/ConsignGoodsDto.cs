
namespace Lbc.WebApi.Modes {


    /// <summary>
    /// 委托货物
    /// </summary>
    public class ConsignGoodsDto
    {

        /// <summary>
        /// 委托业务货物流水号
        /// </summary>
        public decimal ConsignGoodsId { get; set; }

        /// <summary>
        /// 委托业务流水号
        /// </summary>
        public decimal ConsignId { get; set; }

        /// <summary>
        /// 委托拆单流水号
        /// </summary>
        public decimal ConsignSeparateId { get; set; }

        /// <summary>
        /// 货代货物流水号
        /// </summary>
        public decimal FfGoodsId { get; set; }

        /// <summary>
        /// 唛头
        /// </summary>
        public string Marks { get; set; }

        /// <summary>
        /// 箱号
        /// </summary>
        public string ContainerNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int? Qty { get; set; }

        /// <summary>
        /// 数量单位
        /// </summary>
        public string QtyUnit { get; set; }

        /// <summary>
        /// 货物描述
        /// </summary>
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 毛重(KGS)
        /// </summary>
        public decimal? GrossWeight { get; set; }

        /// <summary>
        /// 体积(CBM)
        /// </summary>
        public decimal? Volume { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Remark { get; set; }

    }
}


