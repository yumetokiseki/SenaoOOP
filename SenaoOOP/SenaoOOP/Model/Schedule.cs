using Newtonsoft.Json;

namespace SenaoOOP.Model
{
    /// <summary>
    /// 排程 Model
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// 檔案格式
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 排程所處理的時間 
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// 排程執行的間隔
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }
    }
}
