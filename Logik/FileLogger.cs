using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class FileLogger : ILogging
    {
        private string filepath;
        public FileLogger(string pfad) {
            filepath = pfad;
        }
        public void Log(string message)
        {
            // schreibt in textdatei
        }
    }
}
