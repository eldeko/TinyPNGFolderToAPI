using System;
using System.Threading.Tasks;
using TinyPng;

namespace TinyBackend
{
    public class MiddleService
    {
        private readonly Converter converter = new Converter();
        public static int monthConvs { get; set; }

        public MiddleService()
        {
        }     

        public async Task CallService(string SourceFolder, string TargetFolder, bool rootFolderOpt, bool onlyImagesOpt)
        {
            try
            {
                await converter.CopyFolderAsync(SourceFolder, TargetFolder, rootFolderOpt, onlyImagesOpt);
            }
            catch (AccountException e)
            {
                Console.WriteLine("Monthly limit exceed exception");
                Console.WriteLine("Retry after changing API Key");
            }
            catch (ClientException e)
            {
                Console.WriteLine("Check your source image and request options.");
            }
            catch (ServerException e)
            {
                Console.WriteLine("Temporary issue with the Tinify API.");
            }
            catch (ConnectionException e)
            {
                Console.WriteLine("A network connection error occurred.");
            }
            catch (TinyPng.Exception e)
            {
                Console.WriteLine("Something else went wrong, unrelated to the Tinify API. " + e.InnerException.Message);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Unhandlded System Exception: " + e.InnerException.Message);
            }
        }
    }
}
