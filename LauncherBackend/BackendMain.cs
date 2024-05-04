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
using LauncherBackend.Repository;

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
            //      Database Connections
            //---------------------------------
            GameController gameController = new GameController();
            gameController.ConnectToGameDataBase("C:/Server/Databases");

            AppController appController = new AppController();
            appController.ConnectToApplicationDataBase("C:/Server/Databases");

            //--------------------------------------------------------------------------
            //                          TEST BRANCH 
            //--------------------------------------------------------------------------

            BagProjectDTO project = new BagProjectDTO {
                ProjectTitle = "BunkerOS",
                InstallationPath = "C:/Server/Test/Project",
                Suit = "Bag"
            };

            ProjectController projectController = new ProjectController();
            projectController.BagProjectWizard(project);
            //--------------------------------------------------------------------------
        }
    }
}
