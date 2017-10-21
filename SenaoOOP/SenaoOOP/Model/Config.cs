using Newtonsoft.Json;

namespace SenaoOOP.Model
{
    /// <summary>
    /// 設定 Model
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 檔案格式
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 備份檔案的目錄 
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 是否處理子目錄
        /// </summary>
        [JsonProperty("subDirectory")]
        public bool SubDirectory { get; set; }

        /// <summary>
        /// 備份單位
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 處理完是否刪除檔案
        /// </summary>
        [JsonProperty("remove")]
        public bool Remove { get; set; }

        /// <summary>
        /// 處理方式
        /// </summary>
        [JsonProperty("handler")]
        public string Handler { get; set; }

        /// <summary>
        /// 處理後儲存方式
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 處理後的目錄
        /// </summary>
        [JsonProperty("dir")]
        public string Dir { get; set; }

        /// <summary>
        /// 資料庫連接字串
        /// </summary>
        [JsonProperty("connectionString")]
        public string ConnectionString { get; set; }
    }
}
