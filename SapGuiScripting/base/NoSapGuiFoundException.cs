using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapGuiScripting {
    class NoSapGuiFoundException : Exception {

        public NoSapGuiFoundException() {
        }

        public NoSapGuiFoundException(string message) : base(message) {
        }

        public NoSapGuiFoundException(string message, Exception inner) : base(message, inner) {
        }
    }
}
