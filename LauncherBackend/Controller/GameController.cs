using LauncherBackend.Exceptions;
using LauncherBackend.Global;
using LauncherBackend.Modells;
using LauncherBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Controller {
    public class GameController {
        private GameDataService gameDataService = new GameDataService();


        //-----------------------------
        // GameDataBase Service Calls
        //-----------------------------
        public void ConnectToGameDataBase(string url) { 
            gameDataService.ConnectToGameDataBase(url);
        }

        public void InsertGameToTheDatabase(GameDataDTO game) {
            gameDataService.InsertGame(game);
        }

        public GameDataDTO GetGameByIDFromTheDatabase(int id) {
            return gameDataService.GetGameByIDFromTheDatabase(id);
        }

        public List<GameDataDTO> GetAllGamesFromDatabase() {
            return gameDataService.GetAllGamesFromDatabase();
        }


        //-----------------------------
        //  Installation Service Calls
        //-----------------------------
        public void InstallGame(GameDataDTO game, string installationPath) {
            // Install the app
            try {
                FileSystemService.InstallGame(game, installationPath);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        
            // Save to the AppData
        }
    }
}
