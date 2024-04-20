using LauncherBackend.DTOs;
using LauncherBackend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Services {
    public class GameDataService {
        private LauncherRepository launcherRepository;

        public GameDataService(string path) {
            launcherRepository = new LauncherRepository();
            launcherRepository.ConnectGameDatabase(path);
        }

        public void AddGame(GameDTO game) { 
            launcherRepository.AddGame(game);
        }

        public List<GameDTO> GetAllGames() {
            return launcherRepository.GetAllGames();
        }
    }
}
