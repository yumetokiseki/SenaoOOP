using Newtonsoft.Json;

namespace SenaoOOP.Model
{
    /// <summary>
    /// 排程 Model
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="ext">檔案格式</param>
        /// <param name="time">排程所處理的時間</param>
        /// <param name="interval">排程執行的間隔</param>
        public Schedule(string ext, string time, string interval)
        {
            this.Ext = ext;
            this.Time = time;
            this.Interval = interval;
        }

        /// <summary>
        /// 檔案格式
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; private set; }

        /// <summary>
        /// 排程執行的間隔
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; private set; }

        /// <summary>
        /// 排程所處理的時間
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; private set; }
    }
}