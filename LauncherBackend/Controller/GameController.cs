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
        private FTPService ftpService = new FTPService();

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
        //     FTP Service Calls
        //-----------------------------
        public void ConnectToFTPServer(string url) {
            ftpService.ConnectToFTPServer(url);
        }
    }
}
