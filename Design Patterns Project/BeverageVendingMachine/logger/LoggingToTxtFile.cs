using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.logger
{
    internal class LoggingToTxtFile : Logging
    {
        private string text = "";
        public override void InsertLog(string text)
        {
            this.text = DateTime.Now.Hour+": "+DateTime.Now.Minute+": "+ DateTime.Now.Second+"\n"+ text;
            OpenLoggerFile("txt");
        }

        public override void WriteToLogger(string path)
        {
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(this.text);
                file.Close();
                file.Dispose();
            }
        }
    }
}
