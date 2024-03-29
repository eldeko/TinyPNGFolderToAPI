﻿using TinyPng;

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
            catch(TinyPng.Exception ex)
            {
                throw ex;
            }                
        }
    }
}
