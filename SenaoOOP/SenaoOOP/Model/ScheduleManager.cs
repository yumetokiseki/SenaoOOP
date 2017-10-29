using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SenaoOOP.Model
{
    /// <summary>
    /// 排程管理器
    /// </summary>
    public class ScheduleManager : JsonManager
    {
        /// <summary>
        /// JSON 路徑
        /// </summary>
        private string Path = @"../../JSON/schedule.json";

        /// <summary>
        /// 計數器
        /// </summary>
        public int Count
        {
            get { return this.Schedules.Count(); }
        }

        /// <summary>
        /// 排程列表
        /// </summary>
        private List<Schedule> Schedules { get; set; } = new List<Schedule>();

        /// <summary>
        /// indexers
        /// </summary>
        /// <param name="i">index</param>
        /// <returns>Schedule</returns>
        public Schedule this[int i]
        {
            get { return this.Schedules[i]; }
            set { this.Schedules[i] = value; }
        }

        /// <summary>
        /// 讀取檔案
        /// </summary>
        public override void ProcessJsonConfig()
        {
            dynamic scheduleObject = this.GetJsonObject(this.Path);

            foreach (var item in scheduleObject["schedules"])
            {
                this.Schedules.Add(
                                    new Schedule(
                                                    (string)item["ext"],
                                                    (string)item["time"],
                                                    (string)item["interval"]));
            }
        }
    }
}