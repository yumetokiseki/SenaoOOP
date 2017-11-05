using SenaoOOP.Interface;
using SenaoOOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SenaoOOP.Service
{
    /// <summary>
    /// 備份服務
    /// </summary>
    public class MyBackupService
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
            List<Candidate> candidates = this.FindFiles();

            foreach (Candidate candidate in candidates)
            {
                this.BroadcastToHandlers(candidate);
            }
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

        private void BroadcastToHandlers(Candidate candidate)
        {
            List<Handler> handlers = this.FindHandlers(candidate);
            byte[] target = null;

            foreach (Handler handler in handlers)
            {
                target = handler.Perform(candidate, target);
            }
        }

        private List<Candidate> FindFiles()
        {
            // Homework 4
            List<Candidate> candidates = new List<Candidate>();
            return candidates;
        }

        private List<Handler> FindHandlers(Candidate candidate)
        {
            List<Handler> handlers = new List<Handler>();
            handlers.Add(HandlerFactory.Create("file"));

            Config config = candidate.Config;

            foreach (string handler in config.Handlers)
            {
                handlers.Add(HandlerFactory.Create(handler));
            }

            handlers.Add(HandlerFactory.Create(config.Destination));

            return handlers;
        }
    }
}