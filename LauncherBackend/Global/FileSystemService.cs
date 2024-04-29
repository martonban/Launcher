using LauncherBackend.Exceptions;
using LauncherBackend.Modells;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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

namespace LauncherBackend.Global
{
    public class FileSystemService
    {
        public void InstallGame(string ftpPath, GameDataDTO game, string installationPath)
        {
            //if (CanGameInstall(ftpPath, game, installationPath)) {
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(ftpPath + game.FTPFolderPath + game.FileName, installationPath + "/" + game.GameTitle);
            }
            catch (IOException)
            {
                Console.WriteLine("Error FileSystemService: Game not able to install! \n");
                Console.WriteLine("Probably invalid Path");
            }
            //} else {
            //throw new CannotInstallGameExeption();
            //}
        }

        //------------------
        //    Checker
        //------------------
        //private bool CanGameInstall(string ftpPath, GameDataDTO game, string installationPath) {
        //return (IsItExistsInTheFTP(ftpPath, game) && InstallationPathIsExist(installationPath));
        //}

        private bool InstallationPathIsExist(string installationPath)
        {
            if (Directory.Exists(installationPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //private bool IsItExistsInTheFTP(string ftpPath, GameDataDTO game) { 

        //}

    }
}
