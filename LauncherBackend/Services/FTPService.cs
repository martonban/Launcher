using LauncherBackend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Services { 
    public class FTPService {
        private FTPRepository ftpRepository = new FTPRepository();


        public void ConnectToFTPServer(string url) {
            ftpRepository.ConnectToFTPServer(url);
        }
    }
}
