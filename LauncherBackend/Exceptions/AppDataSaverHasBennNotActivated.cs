using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class AppDataSaverHasBennNotActivated : Exception {
        public AppDataSaverHasBennNotActivated() { }
        
        public AppDataSaverHasBennNotActivated(string msg): base(msg) { }
    }
}
