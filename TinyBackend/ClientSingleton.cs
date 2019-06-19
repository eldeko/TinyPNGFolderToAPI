using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TinyPng;

namespace TinyBackend
{
   public class ClientSingleton
    {
        private static readonly TinyPngClient singleClient;
       public static TinyPngClient GetSingleClient()
        {
            try
            {
                string apiKey = SaveData.ReadApiKey();
                if (singleClient == null)
                {
                    return new TinyPngClient(apiKey);
                }
                return singleClient;
            }
            catch(Exception ex)
            {
                return null;
            }
                
        }
    }
}
