using LauncherBackend.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------------------
//              Launcher - FTPServer
//              Márton Bán (C) 2024
//  
//  This is an imitates the FTP Server and a Downlad
//  Manager class. Throw the service layer the GUI
//  will request the installation.
//---------------------------------------------------

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

        public void IstallApplication(string ftpPathFolder, string installationPath, string appName) {
            Console.WriteLine(FTPFilePath + ftpPathFolder + appName);
            if (CheckAppIsExistInTheServer(ftpPathFolder + appName) && isConnected) {
                Install(ftpPathFolder, installationPath, appName);  
            } else {
                throw new CannotInstallAppException();
            }
        }


        //-------------------------------------------
        //    InstallApplication Helper Functions
        //-------------------------------------------
        private bool CheckAppIsExistInTheServer(string path) {
            if (File.Exists(FTPFilePath + path)) {
                return true;
            } else {
                return false;
            }
        }

        private void Install(string ftpPath, string installationPath, string appName) {
            // Extract
            System.IO.Compression.ZipFile.ExtractToDirectory(FTPFilePath + ftpPath + appName, installationPath);
        }

    }
}
