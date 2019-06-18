using System;
using System.Collections.Generic;
using System.Text;

namespace TinyBackend
{
   public static class Configs
    {       
       public static string SourceDir()
        {
            string inputString  = "C:\\TestImage";
                 return inputString;
        }
       
       public static string BaseOutputDir()
        {
            string outPutString = "C:\\Output";
                return outPutString;
        }
    }
}
