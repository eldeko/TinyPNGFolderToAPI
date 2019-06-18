using System;
using System.Collections.Generic;
using System.Text;

namespace TinyBackend
{
    public static class LoggerService
    {
        private static Logger logger;

        public static Logger GetLogger()
        {
            if (logger == null)
            {
                return new Logger();
            }
            return logger;
        }
    }
}
