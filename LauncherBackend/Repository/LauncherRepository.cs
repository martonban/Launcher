using LauncherBackend.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------------------
//          Launcher - LauncherRepository
//              Márton Bán (C) 2024
//
//  This repositry layer will store and handle data with
//  the database. Currently we don't have database, so
//  I will store data localy. With this calss we will
//  Communicate the databases.
//
//  --------------------------------------------------

namespace LauncherBackend.Repository {
    class LauncherRepository {
        private GameDataBase gameDataBase;

        public LauncherRepository(string ftpFilePath) {
            // Connect to the database
            try {
                gameDataBase = new GameDataBase(ftpFilePath);
            } catch (DataBaseConnectionException exp) { 
                // TODO Tell the upper layers
            }
        }

        public void AddGame(GameDTO game) {
            gameDataBase.InsertGame(game);
        }

        public List<GameDTO> GetAllGames() {
            return gameDataBase.GetAllGames();
        }
    }
}
