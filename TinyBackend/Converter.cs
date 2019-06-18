using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TinyPng;
using TinyPng.Responses;

namespace TinyBackend
{
    public class Converter
    {
           
        TinyPngClient tinyPngClient = ClientSingleton.GetSingleClient();
        Logger logger = LoggerService.GetLogger();
        public Converter()
        {
        }

        public async Task CopyFolderAsync(string sourceFolder, string destFolder)
        {
           
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);

                if  (Path.GetExtension(name) == ".png" ||
                     Path.GetExtension(name) == ".jpg" ||
                     Path.GetExtension(name) == ".jpeg")

                {
                    if (File.Exists(dest))
                    {
                        Console.WriteLine("Skipping convertion of existing file: " + file.ToString());
                    }
                    else {
                        Console.WriteLine("Converting and saving: " + file.ToString());
                            await ConvertAsync(file, dest);
                    }
                }
                else
                {
                    if (File.Exists(dest))
                    {
                        Console.WriteLine("Skipping copy of existing file: " + file.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Copying: " + file.ToString());

                             File.Copy(file, dest);
                    }
                }
            }

            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
               
                    Console.WriteLine("Creating folder: " + folder);
                    await CopyFolderAsync(folder, dest);               
            }
        }
        public async Task ConvertAsync(string input, string output)
        {
            try
            {
                await tinyPngClient.Compress(input)
                                       .Download()
                                       .SaveImageToDisk(output);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To be implemented (not in use nor working)
        public bool IsParent(string input, string output)
        {
           bool IsParent = true;
            var parentUri = new Uri(input);
            var childUri = new Uri(output);
            if (parentUri != childUri && parentUri.IsBaseOf(childUri))
            {
                IsParent = false;
                return IsParent;
            }
            return IsParent;
        }        
    }
}