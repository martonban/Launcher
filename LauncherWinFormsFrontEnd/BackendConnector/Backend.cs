using LauncherBackend.Controller;
using LauncherBackend.Global;
using LauncherBackend.Modells;
using LauncherBackend.Models;
using LauncherWinFormsFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------------------
//     LauncherWinFormsFrontEnd - BackendConnector
//          Copyright Marton Ban (C) 2024
//  This class will call every functions what backend 
//  has. Throw this class the frontend will recive data
//  from backend.
//-----------------------------------------------------

namespace LauncherWinFormsFrontEnd.BackendConnector {
    public class Backend {

        // This class will handle all of the administration task of the application.
        // Note: We will not use this class, we just need to activate it, and attcach to a controller
        public LauncherBackend.Databases.AppDataSaver appDataSaver = new LauncherBackend.Databases.AppDataSaver();

        // This calss will handle all of the game data
        public LauncherBackend.Controller.GameController gameController;

        // This class will handle all of the application data
        public LauncherBackend.Controller.AppController appController;

        // This class will handle all of the project data
        public LauncherBackend.Controller.ProjectController projectController;



        //--------------------------------------------------------------
        //                         BACKEND INIT
        //--------------------------------------------------------------
        public Backend() {
            // Activate the AppDataSaver subsystem
            try {
                appDataSaver.Activate();
                Debug.WriteLine("AppdataSaver Activation was SUCCESSFULY!");
            } catch (Exception exp) {
                Debug.WriteLine(exp.Message);
            }

            // Attach it to the controller
            try {
                AppDataController.AttachAppdataSaver(appDataSaver);
                Debug.WriteLine("AppdataSaver has been Attached to the controller SUCCESSFULY!");
            } catch (Exception exp) {
                Debug.WriteLine(exp.Message);
            }

            // FTP Connection
            try {
                FTP.Connect("C:/Server/FTP");
                Debug.WriteLine("FTP server connection is SUCCESSFUL!");
            } catch (Exception e) {
                Debug.WriteLine(e);
            }

            // Game Database Connection
            gameController = new GameController();
            gameController.ConnectToGameDataBase("C:/Server/Databases");

            // App Database Connection
            appController = new AppController();
            appController.ConnectToApplicationDataBase("C:/Server/Databases");
        }

        //--------------------------------------------------------------
        //                          GAME CALLS
        //--------------------------------------------------------------
        public Game GetGameById(int ID) {
            return GameConverter.GameDTOToGameConverter(gameController.GetGameByIDFromTheDatabase(ID)); 
        }

        public List<Game> GetAllGames() {
            List<Game> games = new List<Game>();
            List<GameDataDTO> gamesFromDatabase = gameController.GetAllGamesFromDatabase();
            Game game;
            foreach (GameDataDTO gameDTO in gamesFromDatabase) {
                game = GameConverter.GameDTOToGameConverter(gameDTO);
                games.Add(game);
            }
            return games;
        }

        public void InstallGame(Game game, string instalationPath) {
            GameDataDTO dto = GameConverter.GameToGameDataDTOConerter(game);
            gameController.InstallGame(dto, instalationPath);
        }

        public List<Game> GetAllInstalledGame() {
            List<GameModel> gamesRecive = new List<GameModel>();
            List<Game> result = new List<Game>();
            try {
                gamesRecive = AppDataController.GetAllGamesFromAppData();
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }

            Game gameresult;
            foreach (GameModel game in gamesRecive) {
                gameresult = GameConverter.GameModelToGameConverter(game);
                result.Add(gameresult);
            }

            return result;
        }

        //--------------------------------------------------------------
        //                      APPLICATION CALLS
        //--------------------------------------------------------------
        public App GetAppByID(int id) {
            AppDTO app = appController.GetApplicationByIDFromTheDatabase(id);
            return AppConverter.AppDTOToAppCoverter(app);
        }

        public void InstallApp(App app, string instalationPath) {
            AppDTO dto = AppConverter.AppToAppDTOConverter(app);
            appController.InstallApp(dto, instalationPath);
        }
    }
}
