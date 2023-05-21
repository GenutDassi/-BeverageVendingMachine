using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.logger
{
    public abstract class Logging
    {
        const string PATH = "..\\..\\..\\..\\logger";
        public abstract void InsertLog(string row);
        public abstract void WriteToLogger(string row);
        public void OpenLoggerFile(string extention)
        {
            if (!Directory.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
            }
            string FullPath = $"{PATH}\\{DateTime.Now:dd_MM_yy}.{extention}";
            if (!File.Exists(FullPath))
            {
                using (File.Create(FullPath));
            }
            WriteToLogger(FullPath);
        }
 
    }


        
    
}
