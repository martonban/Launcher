using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class ShitHitsTheFanException : Exception {
        public ShitHitsTheFanException() { }
        
        public ShitHitsTheFanException(string msg): base(msg)  { }
    }
}
