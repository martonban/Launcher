using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    internal class CannotInstallGameExeption : Exception{
        public CannotInstallGameExeption() { }

        public CannotInstallGameExeption(string msg) : base(msg) { }
    }
}
