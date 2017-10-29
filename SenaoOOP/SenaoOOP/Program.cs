using SenaoOOP.Model;
using SenaoOOP.Service;
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
            MyBackupService myBackupService = new MyBackupService();
            myBackupService.ProcessJsonConfigs();
            myBackupService.DoBackup();
            Console.ReadLine();
        }
    }
}