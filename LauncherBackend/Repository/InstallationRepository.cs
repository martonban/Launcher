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
//
//  If we want to install an app 
//---------------------------------------------------

namespace LauncherBackend.Repository
{
    public class InstallationRepository
    {
        private string FTPFilePath;
        private bool isConnected = false;

        public void ConnectToServer(string FTPFilePath)
        {
            if (Path.Exists(FTPFilePath))
            {
                this.FTPFilePath = FTPFilePath;
                isConnected = true;
            }
            else
            {
                throw new FTPServerConnectionException();
            }
        }

        public void IstallApplication(string ftpFolderPath, string fileName, string installationPath, string appName)
        {
            Console.WriteLine(FTPFilePath + ftpFolderPath + fileName);
            if (CheckAppIsExistInTheServer(ftpFolderPath + fileName) && isConnected)
            {
                Install(ftpFolderPath, installationPath, fileName, appName);
            }
            else
            {
                throw new CannotInstallAppException();
            }
        }


        //-------------------------------------------
        //    InstallApplication Helper Functions
        //-------------------------------------------
        private bool CheckAppIsExistInTheServer(string path)
        {
            if (File.Exists(FTPFilePath + path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Install(string ftpPath, string installationPath, string fileName, string appName)
        {
            Console.WriteLine(FTPFilePath + ftpPath + fileName + "\n");
            Console.WriteLine(installationPath);
            // Extract
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(FTPFilePath + ftpPath + fileName, installationPath + "/" + appName);
            }
            catch (IOException)
            {
                Console.WriteLine("App Has been installed");
            }
        }

    }
}
