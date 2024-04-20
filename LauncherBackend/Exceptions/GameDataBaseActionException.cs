using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class GameDataBaseActionException : Exception {
        public GameDataBaseActionException() { }

        public GameDataBaseActionException(string msg) : base(msg) { }

    }
}
