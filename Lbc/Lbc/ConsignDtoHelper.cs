using Lbc.Models;
using Lbc.WebApi.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbc {
    public static class ConsignDtoHelper {

        public static IEnumerable<ConsignDetail> Convert(this ConsignDto dto) {
            if (dto == null)
                return null;

            var lst = new List<ConsignDetail>() {
                new ConsignDetail("", "委托人", dto.ConsignConsigner.ConsignerNameCn ),
                new ConsignDetail("", "联系人", dto.ConsignConsigner.ConsignContacts !=null && dto.ConsignConsigner.ConsignContacts.Count() > 0 ? string.Format("{0} {1}", dto.ConsignConsigner.ConsignContacts.First().Fullname, dto.ConsignConsigner.ConsignContacts.First().Mobile) : "" ),
                new ConsignDetail("", "柜型柜量", dto.ConsignContainerGoods.ContaDesc),
                new ConsignDetail("", "货物", string.Join(";", dto.ConsignContainerGoods.GoodsDescs)),
                new ConsignDetail("", "船东", string.Join(";", dto.ConsignCarrier.CarrierName)),
                new ConsignDetail("费用资料", "应收", ""),
                new ConsignDetail("费用资料", "应付", ""),
                new ConsignDetail("费用资料", "参考利率", ""),
                new ConsignDetail("SO提单", "订舱号", ""),
                new ConsignDetail("SO提单", "提单类型", ""),
                new ConsignDetail("业务资料", "贸易条款", ""),
                new ConsignDetail("业务资料", "运输条款", ""),
            };

            return lst;
        }

    }
}
