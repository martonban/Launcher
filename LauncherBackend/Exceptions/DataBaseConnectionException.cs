using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class DataBaseConnectionException : Exception {
        public DataBaseConnectionException() { }

        public DataBaseConnectionException(string msg) : base(msg) { }

    }
}
