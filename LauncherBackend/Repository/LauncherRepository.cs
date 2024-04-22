using LauncherBackend.Database;
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
//  This class main aim is to be the entry point for 
//  servecies to handle data. Almost every request
//  will go throw of this calss
// ---------------------------------------------------

namespace LauncherBackend.Repository
{
    class LauncherRepository {
        // Game Database
        // The Store's offer 
        private GameDataBase gameDataBase;
        private bool gameDataInit = false;


        public LauncherRepository() { }


        //----------------------------------------------
        //        GameData realated functions 
        //----------------------------------------------
        public void ConnectGameDatabase(string databasePath) {
            try {
                this.gameDataBase = new GameDataBase(databasePath);
                this.gameDataInit = true;
            } catch (GameDataBaseConnectionException exp) { 
                // TODO Tell the signal system
            }
        }

        public void AddGame(GameDTO game) {
            if (gameDataInit) {
                gameDataBase.InsertGame(game);
            } else {
                throw new GameDataBaseConnectionException();
            }
            
        }

        public List<GameDTO> GetAllGames() {
            if (gameDataInit) {
                return gameDataBase.GetAllGames();
            } else {
                throw new GameDataBaseActionException();
            }
        }
    }
}
