﻿using Lbc.WebApi.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbc.WebApi.Modes {

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
    public enum ConsignStatus : int {
        历史 = -10,
        客户草稿 = 0,
        客户提交 = 5,
        业务草稿 = 10,
        业务客户确认 = 15,
        业务客户异议 = 16,
        业务提交 = 99,
        商务接单 = 101,
        商务审核中 = 102,
        商务审核拒绝 = 104,
        商务审核通过 = 109,
        订舱接单 = 201,
        订舱订舱失败 = 204,
        订舱订舱成功 = 299,
        操作接单 = 301,
        操作拖车报关已安排 = 310,
        操作还柜中 = 320,
        操作已还柜 = 329,
        衬料操作 = 331,
        已装船 = 350,
        已收单 = 351,
        已出提单 = 352,
        电放 = 353,
        扣单中 = 501,
        未应收放单 = 511,
        未应收电放 = 512,
        已放单 = 521,
        已电放 = 522,
        财务完成 = 699,
        已完成 = 999
    }
}
