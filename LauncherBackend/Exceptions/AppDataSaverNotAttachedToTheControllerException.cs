using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class AppDataSaverNotAttachedToTheControllerException : Exception {
        public AppDataSaverNotAttachedToTheControllerException() { }

        public AppDataSaverNotAttachedToTheControllerException(string msg) : base(msg) { }
    }
}
