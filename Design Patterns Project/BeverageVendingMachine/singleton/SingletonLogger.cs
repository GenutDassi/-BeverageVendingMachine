using BeverageVendingMachine.logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.singleton
{
    internal static class SingletonLogger
    {
        private static Logging instance;
        public static Logging GetLoggerInstance()
        {
            if (instance == null)
            {
                //if you want a diffrent format of logger don't forget to change to the new instance
                instance = new LoggingToTxtFile();
            }
            return instance;
        }
    }
}
