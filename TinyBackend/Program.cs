using System;
using System.IO;
using System.Threading.Tasks;
using TinyPng;
using TinyPng.Responses;

namespace TinyBackend
{
    class Program
    {          
        static async Task Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
           
           
            string source = Console.ReadLine();
            
            string output = Console.ReadLine();
            if (output == string.Empty)
            {
                output = Configs.BaseOutputDir();
            }          

            Converter converter = new Converter();

            try
            {               
                 await converter.CopyFolderAsync(source, output);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}