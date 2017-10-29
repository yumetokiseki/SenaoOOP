using Newtonsoft.Json;
using System.IO;

namespace SenaoOOP.Model
{
    /// <summary>
    /// JSON 管理器
    /// </summary>
    public abstract class JsonManager
    {
        /// <summary>
        /// 讀取 JSON 至物件中
        /// </summary>
        public abstract void ProcessJsonConfig();

        /// <summary>
        /// 讀取 JSON 檔案
        /// </summary>
        /// <param name="path">路徑</param>
        /// <returns>JSON 物件</returns>
        protected object GetJsonObject(string path)
        {
            string configValue = File.ReadAllText(path);
            return JsonConvert.DeserializeObject(configValue);
        }
    }
}