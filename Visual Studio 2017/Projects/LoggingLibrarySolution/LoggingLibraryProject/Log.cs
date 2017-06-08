using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibraryProject
{

    public class Log {
        private static int nextId = 1;

        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public string Username { get; set; }
        public string Classname { get; set; }
        public string Methodname { get; set; }
        public Log RelatedLog { get; set; }

        public Log (string Message) {
            this.Id = Log.nextId++;
            this.Message = Message;
            this.Timestamp = DateTime.Now;
        }
    }
}
