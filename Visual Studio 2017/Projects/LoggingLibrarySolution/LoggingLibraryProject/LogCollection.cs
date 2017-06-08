using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibraryProject {

   
    public class LogCollection : List<Log> {
        public static LogCollection Logs = new LogCollection();

        public static void Logger(string Message) {
            Log log = new Log(Message);
            Logs.Add(log);
        }
    }
}
     