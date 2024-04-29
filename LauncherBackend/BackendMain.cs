using LauncherBackend.Controller;
using LauncherBackend.Modells;
using LauncherBackend.Global;
using LauncherBackend.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------------------
//              Launcher - BackendMain
//              Márton Bán (C) 2024
//  
//  This is the entry point of the backend. In this
//  approch some of our data is not go throw all of
//  the layers or skipping some of it. The main reason
//  for this, is becasue there are data's where we
//  doesn't need to do anything, for example GameDTO. 
//---------------------------------------------------

namespace LauncherBackend
{
    public class BackendMain {
        static void Main(string[] args) {
            GameController gameController = new GameController();

            try {
                FTP.Connect("C:/Server/FTP");
            } catch (Exception e) {
                Console.WriteLine(e);
            }

            gameController.ConnectToGameDataBase("C:/Server/Databases");

            GameDataDTO gameDataDTO = gameController.GetGameByIDFromTheDatabase(2);

            //string path = FTP.GetRoot() + gameDataDTO.FTPFolderPath + gameDataDTO.FileName;
            //string path = FTP.GetRoot() + gameDataDTO.FTPFolderPath + "notvalid.zip";
            string path = FTP.GetRoot() + gameDataDTO.FTPFolderPath + "TheThirdWish_v14.zip";

            if (FTP.IsThisFileExistInFTP(path)) {
                Console.WriteLine("true");
            } else { 
                Console.WriteLine("false");
            }
            
        }
    }
}
