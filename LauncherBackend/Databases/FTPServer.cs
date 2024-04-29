using LauncherBackend.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Databases {
    public class FTPServer {
        private string root;

        public void Connect(string URL) {
            if (!Directory.Exists(URL)) {
                throw new FTPServerConnectionException("Cannot connect to the FTP server: Invalid URL/Server is not avaliable");
            } else { 
                this.root = URL;
            }
        }

        public string GetRoot() { 
            return this.root;
        }
    }
}
