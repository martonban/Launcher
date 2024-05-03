using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Exceptions {
    public class AppIsExistsInTheDataBaseWithThisIDExeption : Exception {
        public AppIsExistsInTheDataBaseWithThisIDExeption() { }

        public AppIsExistsInTheDataBaseWithThisIDExeption(string msg) : base(msg) { }
    }
}
