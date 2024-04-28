using LauncherBackend.Databases;
using LauncherBackend.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Repository {
    public class FTPRepository {
        private bool isConnectedToFTPServer = false;
        private FTPServer ftpServer = new FTPServer();

        public void ConnectToFTPServer(string url) {
            try {
                ftpServer.Connect(url);
            } catch (FTPServerConnectionException exp) { 
                Console.WriteLine(exp.Message);
            }
            
        }
    }
}
