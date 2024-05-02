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

            /*
            GameDataDTO game1 = gameController.GetGameByIDFromTheDatabase(1);
            GameDataDTO game2 = gameController.GetGameByIDFromTheDatabase(2);
            string installationPath1 = "C:/Server/Test";
            string installationPath2 = "C:/Server/Test";

            GameModel gameModel1 = new GameModel {
                GameDataDTO = game1,
                InstallationPath = installationPath1
            };


            GameModel gameModel2 = new GameModel {
                GameDataDTO = game2,
                InstallationPath = installationPath2
            };

            
            appDataSaver.games.Add(gameModel2);
            */

            //appDataSaver.RefreshGames();

            GameDataDTO game1 = gameController.GetGameByIDFromTheDatabase(1);
            string installationPath1 = "C:/Server/Test/";

            gameController.InstallGame(game1, installationPath1);

            //--------------------------------------------------------------------------
        }
    }
}
