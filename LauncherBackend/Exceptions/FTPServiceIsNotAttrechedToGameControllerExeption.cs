using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    internal class FTPServiceIsNotAttrechedToGameControllerExeption : Exception {
        public FTPServiceIsNotAttrechedToGameControllerExeption() { }

        public FTPServiceIsNotAttrechedToGameControllerExeption(string msg) : base(msg) { }
    }
}
