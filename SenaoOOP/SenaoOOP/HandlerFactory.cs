using Newtonsoft.Json;
using SenaoOOP.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace SenaoOOP
{
    public class HandlerFactory
    {
        private static Dictionary<string, string> handlerDictionary;

        static HandlerFactory()
        {
            string jsonString = File.ReadAllText("../JSON/handler_mapping.json");
            HandlerFactory.handlerDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
        }

        public static Handler Create(string key)
        {
            return (Handler)Activator.CreateInstance("MyBackupService", HandlerFactory.handlerDictionary[key]).Unwrap();
        }
    }
}