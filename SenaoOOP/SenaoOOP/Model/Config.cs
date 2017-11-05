using Newtonsoft.Json;
using System.Collections.Generic;

namespace SenaoOOP.Model
{
    /// <summary>
    /// 設定 Model
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="ext">檔案格式</param>
        /// <param name="location">備份檔案的目錄</param>
        /// <param name="subDirectory">是否處理子目錄</param>
        /// <param name="unit">備份單位</param>
        /// <param name="remove">處理完是否刪除檔案</param>
        /// <param name="handlers">處理方式</param>
        /// <param name="destination">處理後儲存方式</param>
        /// <param name="dir">處理後的目錄</param>
        /// <param name="connectionString">資料庫連接字串</param>
        public Config(
                      string ext,
                      string location,
                      bool subDirectory,
                      string unit,
                      bool remove,
                      List<string> handlers,
                      string destination,
                      string dir,
                      string connectionString)
        {
            this.Ext = ext;
            this.Location = location;
            this.SubDirectory = subDirectory;
            this.Unit = unit;
            this.Remove = remove;
            this.Handlers = handlers;
            this.Destination = destination;
            this.Dir = dir;
            this.ConnectionString = connectionString;
        }

        /// <summary>
        /// 資料庫連接字串
        /// </summary>
        [JsonProperty("connectionString")]
        public string ConnectionString { get; private set; }

        /// <summary>
        /// 處理後儲存方式
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; private set; }

        /// <summary>
        /// 處理後的目錄
        /// </summary>
        [JsonProperty("dir")]
        public string Dir { get; private set; }

        /// <summary>
        /// 檔案格式
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; private set; }

        /// <summary>
        /// 處理方式
        /// </summary>
        [JsonProperty("handlers")]
        public List<string> Handlers { get; private set; }

        /// <summary>
        /// 備份檔案的目錄
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; private set; }

        /// <summary>
        /// 處理完是否刪除檔案
        /// </summary>
        [JsonProperty("remove")]
        public bool Remove { get; private set; }

        /// <summary>
        /// 是否處理子目錄
        /// </summary>
        [JsonProperty("subDirectory")]
        public bool SubDirectory { get; private set; }

        /// <summary>
        /// 備份單位
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; private set; }
    }
}