using System;
using System.IO;
using System.Threading.Tasks;
using TinyPng;

namespace TinyBackend
{
    public class Converter
    {
        TinyPngClient tinyPngClient = ClientSingleton.GetSingleClient();

        public Converter()
        {
        }

        public async Task CopyFolderAsync(string sourceFolder, string destFolder, bool rootFolderOpt, bool onlyImagesOpt)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);

                if (Path.GetExtension(name).ToLower() == ".png" ||
                    Path.GetExtension(name).ToLower() == ".jpg" ||
                    Path.GetExtension(name).ToLower() == ".jpeg")

                {
                    if (File.Exists(dest))
                    {
                        //Console.WriteLine("Skipping already processed Files...");
                        // alreadySkipped = true;
                    }
                    else
                    {
                        Console.WriteLine("Converting and saving: " + file.ToString());
                        await ConvertAsync(file, dest);
                    }
                }
                else
                {
                    if (onlyImagesOpt == false && File.Exists(dest) == false)
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
                await CopyFolderAsync(folder, dest, rootFolderOpt, onlyImagesOpt);
            }
        }

        public async Task ConvertAsync(string input, string output)
        {
            try
            {
                var compressResponse = await tinyPngClient.Compress(input);
                MiddleService.monthConvs = compressResponse.CompressionCount;
                var download = await DownloadExtensions.Download(compressResponse);

                await ImageDataExtensions.SaveImageToDisk(download, output);

            }
            catch (ServerException ex)
            {
                if (TinyPng.Exception.exQuantity < 5)
                {
                    Console.WriteLine("Retrying from Exception in 5 seconds.");
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("Retry count: " + TinyPng.Exception.exQuantity);
                    await ConvertAsync(input, output);
                }
                else
                {
                    Console.WriteLine("Something is wrong with the server. Please try again later");
                    throw ex;
                }
                TinyPng.Exception.exQuantity++;
            }
        }
    }
}
