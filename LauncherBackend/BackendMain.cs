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
using LauncherBackend.Databases;
using LauncherBackend.Exceptions;
using static System.Net.Mime.MediaTypeNames;
using LauncherBackend.Models;

// --------------------------------------------------
//              Launcher - BackendMain
//              Márton Bán (C) 2024
//
//   This part is a Test Class, later this is gonna be
//   the entry point for the singleton backend. 
//---------------------------------------------------

namespace LauncherBackend
{
    public class BackendMain {
        static void Main(string[] args) {
            // Before we use the backend we need to establish the connection
            // between the backend and the """"servers"""" and others!
            // Note: In the future I can add a Connection Mananger 

            //---------------------------------
            //       AppData Connection
            //---------------------------------
            AppDataSaver appDataSaver = new AppDataSaver();

            try {
                appDataSaver.Activate();
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
            }
            
            try {
                AppDataController.AttachAppdataSaver(appDataSaver);
            } catch (Exception exp) {
               Console.WriteLine(exp.Message);
            }

            //---------------------------------
            //         FTP Connection
            //---------------------------------
            try {
                FTP.Connect("C:/Server/FTP");
            } catch (Exception e) {
                Console.WriteLine(e);
            }

            //---------------------------------
            //      Database Connection
            //---------------------------------
            GameController gameController = new GameController();
            gameController.ConnectToGameDataBase("C:/Server/Databases");



            //--------------------------------------------------------------------------
            //                          TEST BRANCH 
            //--------------------------------------------------------------------------
            
            ApplicationDataBase applicationDataBase = new ApplicationDataBase();

            try {
                applicationDataBase.ConnectToApplicationDataBase("C:/Server/Databases/");
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            AppDTO app1 = new AppDTO { 
                Id = 1,
                AppName = "Composer",
                Description = "Composer is advanced toolset to handle assets to your programming projects",
                Suit = "Universal",
                Version = "0.1.0",
                FTPFolderPath = "/Apps",
                FileName = "/Composer_v010.zip",
                IconPath = "/Media/Apps/Composer/icon.png",
                CoverPath = "/Media/Apps/Composer/cover.png"
            };

            AppDTO app2 = new AppDTO {
                Id = 2,
                AppName = "BagAtlas",
                Description = "BagAtlas is a 2D map Editor for Bag Engine",
                Suit = "Bag",
                Version = "1.0.0",
                FTPFolderPath = "/Apps",
                FileName = "/BagAtlas_v100.zip",
                IconPath = "/Media/Apps/BagAtlas/icon.png",
                CoverPath = "/Media/Apps/BagAtlas/cover.png"
            };

            applicationDataBase.InsertApplication(app2);

            //--------------------------------------------------------------------------
        }
    }
}
