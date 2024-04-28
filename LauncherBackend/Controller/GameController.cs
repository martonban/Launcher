using LauncherBackend.Modells;
using LauncherBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Controller {
    public class GameController {
        private GameDataService gameDataService = new GameDataService();

        public void ConnectToGameDataBase(string url) { 
            gameDataService.ConnectToGameDataBase(url);
        }


        public List<GameDataDTO> GetAllGames() { 
            return gameDataService.GetAllGames();
        }
    }
}
