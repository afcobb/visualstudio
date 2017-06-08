using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {
    class NegativeInputException : Exception {
        public NegativeInputException(string Message, Exception innerException)
                : base(Message, innerException) { 
}
        public NegativeInputException(string Message)
            : base(Message) {

        }
    }
}
