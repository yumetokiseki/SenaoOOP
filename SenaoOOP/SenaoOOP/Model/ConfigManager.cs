using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SenaoOOP.Model
{
    /// <summary>
    /// 設定管理器
    /// </summary>
    public class ConfigManager
    {
        /// <summary>
        /// 設定列表
        /// </summary>
        public List<Config> Configs { get; set; }

        /// <summary>
        /// 計數器
        /// </summary>
        public int Count { get; set; }

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
        public void ProcessConfigs()
        {
            // 讀取 Json 字串
            string fileString = File.ReadAllText(@"../../JSON/config.json");

            // 寫入到物件中
            this.Configs = JsonConvert.DeserializeObject<ConfigManager>(fileString).Configs;

            // 寫入計數器
            this.Count = this.Configs.Count();
        }
    }
}
