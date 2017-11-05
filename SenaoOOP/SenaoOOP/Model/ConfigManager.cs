using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SenaoOOP.Model
{
    /// <summary>
    /// 設定管理器
    /// </summary>
    public class ConfigManager : JsonManager
    {
        /// <summary>
        /// JSON 路徑
        /// </summary>
        private string Path = @"../../JSON/config.json";

        /// <summary>
        /// 計數器
        /// </summary>
        public int Count
        {
            get { return this.Configs.Count(); }
        }

        /// <summary>
        /// 設定列表
        /// </summary>
        private List<Config> Configs { get; set; } = new List<Config>();

        /// <summary>
        /// indexers
        /// </summary>
        /// <param name="i">index</param>
        /// <returns>Config</returns>
        public Config this[int i]
        {
            get { return this.Configs[i]; }
            set { this.Configs[i] = value; }
        }

        /// <summary>
        /// 讀取檔案
        /// </summary>
        public override void ProcessJsonConfig()
        {
            dynamic configObject = this.GetJsonObject(this.Path);
            foreach (var item in configObject["configs"])
            {
                this.Configs.Add(
                                  new Config(
                                                (string)item["ext"],
                                                (string)item["location"],
                                                (bool)item["subDirectory"],
                                                (string)item["unit"],
                                                (bool)item["remove"],
                                                (List<string>)item["handlers"],
                                                (string)item["destination"],
                                                (string)item["dir"],
                                                (string)item["connectionString"]));
            }
        }
    }
}