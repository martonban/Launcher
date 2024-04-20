using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class GameDataBaseConnectionException : Exception {
        public GameDataBaseConnectionException() { }

        public GameDataBaseConnectionException(string msg) : base(msg) { }

    }
}
