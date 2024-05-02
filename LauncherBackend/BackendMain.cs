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
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }


            try {
                AppDataController.AttachAppdataSaver(appDataSaver);
            } catch (AppDataSaverHasBeenAttachedToTheControllerException exp) {
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


            
            GameDataDTO gameDataDTO = gameController.GetGameByIDFromTheDatabase(2);






            //--------------------------------------------------------------------------
        }
    }
}
