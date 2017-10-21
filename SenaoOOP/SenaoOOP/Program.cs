using SenaoOOP.Model;
using System;
using System.Linq;

namespace SenaoOOP
{
    /// <summary>
    /// 主程式
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 主函式
        /// </summary>
        /// <param name="args">args</param>
        public static void Main(string[] args)
        {
            ConfigManager configManager = new ConfigManager();
            configManager.ProcessConfigs();

            Console.WriteLine(configManager[0].ConnectionString);
            Console.WriteLine(configManager[0].Destination);
            Console.WriteLine(configManager[0].Dir);
            Console.WriteLine(configManager[0].Ext);
            Console.WriteLine(configManager[0].Handler);
            Console.WriteLine(configManager[0].Location);
            Console.WriteLine(configManager[0].Remove);
            Console.WriteLine(configManager[0].SubDirectory);
            Console.WriteLine(configManager[0].Unit);

            ScheduleManager scheduleManager = new ScheduleManager();
            scheduleManager.ProcessSchedules();

            Console.WriteLine(scheduleManager.Schedules.First().Ext);
            Console.WriteLine(scheduleManager.Schedules.First().Interval);
            Console.WriteLine(scheduleManager.Schedules.First().Time);

            Console.ReadLine();
        }
    }
}
