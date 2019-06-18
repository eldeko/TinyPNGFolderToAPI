using System;
using System.Collections.Generic;
using System.Text;

namespace TinyBackend
{
   public class Logger
    {
       
        StringBuilder outPutConsole;
        public Logger()
        {
            outPutConsole = new StringBuilder();
        }

        

        public void Log(string ev)
        {
          outPutConsole.Append(ev);                
        }
    }
}
