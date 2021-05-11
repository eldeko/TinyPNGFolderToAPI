using System;
using System.Collections.Generic;
using System.Text;
using TinyPng;

namespace TinyBackend
{
   public class ClientSingleton
    {
        private static readonly TinyPngClient singleClient;
       public static TinyPngClient GetSingleClient()
        {
            if (singleClient == null)
            {
                return new TinyPngClient("INSERT YOUR TINYPNG KEY HERE");
            }
            return singleClient;
        }
    }
}
