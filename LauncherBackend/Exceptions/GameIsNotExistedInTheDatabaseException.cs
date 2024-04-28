using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    internal class GameIsNotExistedInTheDatabaseException : Exception {
        public GameIsNotExistedInTheDatabaseException() { }

        public GameIsNotExistedInTheDatabaseException(string msg) : base(msg) { }
    }
}
