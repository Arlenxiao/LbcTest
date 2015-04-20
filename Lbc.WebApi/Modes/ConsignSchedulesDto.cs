namespace Lbc.WebApi.Modes {

     /// <summary>
    /// 委托船期信息
    /// </summary>
	public class ConsignSchedulesDto
    {
        /// <summary>
        /// 头程船期
        /// </summary>
        public ConsignScheduleDto FeederScheduleInfo { get; set; }

        /// <summary>
        /// 二程船期
        /// </summary>
        public ConsignScheduleDto ScheduleInfo { get; set; }

	}
}


