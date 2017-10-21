using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SenaoOOP.Model
{
    /// <summary>
    /// 排程管理器
    /// </summary>
    public class ScheduleManager
    {
        /// <summary>
        /// 排程列表
        /// </summary>
        public List<Schedule> Schedules { get; set; }

        /// <summary>
        /// 計數器
        /// </summary>
        public int Count { get; set; }

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
        public void ProcessSchedules()
        {
            // 讀取 Json 字串
            string fileString = File.ReadAllText(@"../../JSON/schedule.json");

            // 寫入到物件中
            this.Schedules = JsonConvert.DeserializeObject<ScheduleManager>(fileString).Schedules;

            // 寫入計數器
            this.Count = this.Schedules.Count();
        }
    }
}
