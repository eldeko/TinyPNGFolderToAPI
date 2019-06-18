using System;
using System.Collections.Generic;
using System.Text;

namespace MSGService
{
   public class LoggerService
    {
        private static LoggerService instance = null;
        public StringBuilder loggingOutput { get; set; }

           

        
        public static LoggerService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoggerService();
                    instance.loggingOutput = new StringBuilder();
                }
                return instance;
            }
        }


        public StringBuilder loggingOutput()
        {
            return this.loggingOutput;
        }

        



        public static void LogEvent(string ev, )
        {

            loggingOutput.AppendLine(ev);
        }
    }
}
