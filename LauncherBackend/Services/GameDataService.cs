using LauncherBackend.Exceptions;
using LauncherBackend.Global;
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

        public GameDataDTO GetGameByIDFromTheDatabase(int id) {
            try {
                return gameDatabaseRepository.GetGameByIDFromTheDatabase(id);
            } catch (GameDataBaseConnectionException exp) {
                SignalSystem.ErrorHappend(exp, SignalSystem.ErrorFatal);
                return new GameDataDTO();
            }
        }

        public void InsertGame(GameDataDTO game) {
            try {
                gameDatabaseRepository.InsertGame(game);
            } catch (GameDataBaseConnectionException exp) {
                SignalSystem.ErrorHappend(exp, SignalSystem.ErrorFatal);
            }
        }

        public List<GameDataDTO> GetAllGamesFromDatabase() {
            try {
                return gameDatabaseRepository.GetAllGames();
            } catch (GameDataBaseConnectionException exp) {
                SignalSystem.ErrorHappend(exp, SignalSystem.ErrorFatal);
            }
            return new List<GameDataDTO>();
        }
    }
}
