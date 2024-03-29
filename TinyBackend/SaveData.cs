﻿using System;
using System.IO;

namespace TinyBackend
{
    public static class SaveData
    { 
        public static void SaveCfg (string ApiKey)
        {
            string fileName = Path.GetDirectoryName(Environment.CurrentDirectory) + @"\Cfg.txt";

            StreamWriter file = new StreamWriter(fileName);
            file.Write(ApiKey);
            file.Close();
        }

        public static string ReadApiKey()
        {
            string file = Path.GetDirectoryName(Environment.CurrentDirectory) + @"\Cfg.txt";
            if (File.Exists(file))
            {
               return File.ReadAllText(file);
            }
            return string.Empty;
        }
    }
}
