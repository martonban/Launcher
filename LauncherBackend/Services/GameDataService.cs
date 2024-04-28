using LauncherBackend.Exceptions;
using LauncherBackend.Modells;
using LauncherBackend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Services
{
    public class GameDataService {
        private GameDatabaseRepository gameDatabaseRepository = new GameDatabaseRepository();

        public void ConnectToGameDataBase(string url) {    
            gameDatabaseRepository.ConnectToGameDataBase(url);           
        }

        public void InsertGame(GameDataDTO game) {
            try {
                gameDatabaseRepository.InsertGame(game);
            } catch (GameDataBaseConnectionException exp) { 
                Console.WriteLine(exp.Message);
            }
        }

        public List<GameDataDTO> GetAllGames() {
            return gameDatabaseRepository.GetAllGames();
        }
    }
}
