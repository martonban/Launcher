using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class ThisGameIsNotExistsException : Exception {
        public ThisGameIsNotExistsException() { }

        public ThisGameIsNotExistsException(string msg) : base(msg) { }
    }
}
