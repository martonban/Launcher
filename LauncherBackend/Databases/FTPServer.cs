using LauncherBackend.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Databases {
    public class FTPServer {
        private string FTPFilePath;
        private bool isConnected = false;

        public void ConnectToServer(string FTPFilePath) {
            if (Path.Exists(FTPFilePath)) {
                this.FTPFilePath = FTPFilePath;
                this.isConnected = true;
            } else {
                throw new FTPServerConnectionException();
            }
        }


    }
}
