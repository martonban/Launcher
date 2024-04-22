using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class CannotInstallAppException : Exception {
        public CannotInstallAppException() { }

        public CannotInstallAppException(string msg) : base(msg) { }
    }
}
