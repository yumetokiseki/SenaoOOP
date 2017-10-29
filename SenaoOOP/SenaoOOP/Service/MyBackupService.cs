using SenaoOOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SenaoOOP.Service
{
    /// <summary>
    /// 備份服務
    /// </summary>
    internal class MyBackupService
    {
        /// <summary>
        /// JSON 管理器列表
        /// </summary>
        private List<JsonManager> Managers = new List<JsonManager>();

        /// <summary>
        /// 建構式
        /// </summary>
        public MyBackupService()
        {
            this.Managers.Add(new ConfigManager());
            this.Managers.Add(new ScheduleManager());
        }

        /// <summary>
        /// 執行備份
        /// </summary>
        public void DoBackup()
        {
            Console.WriteLine("Do Backup");
        }

        /// <summary>
        /// 讀取 JSON 至物件
        /// </summary>
        public void ProcessJsonConfigs()
        {
            for (int i = 0; i < this.Managers.Count(); i++)
            {
                this.Managers[i].ProcessJsonConfig();
            }
        }
    }
}