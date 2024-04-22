using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class FTPServerConnectionException : Exception {
        public FTPServerConnectionException() { }

        public FTPServerConnectionException(string msg) : base(msg) { }
    }
}
