using LauncherBackend.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Databases {
    public class FTPServer {

        public void Connect(string URL) {
            if (!Directory.Exists(URL)) {
                throw new FTPServerConnectionException("Cannot connect to the FTP server: Invalid URL/Server is not avaliable");
            }
        }
    }
}
