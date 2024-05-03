using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class AppIsNotExistedInTheDatabaseException : Exception {
        public AppIsNotExistedInTheDatabaseException() { }

        public AppIsNotExistedInTheDatabaseException(string msg) : base(msg) { }
    }
}
