using LauncherBackend.Database;
using LauncherBackend.Exceptions;
using LauncherBackend.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------------------
//          Launcher - GameDatabaseRepository
//              Márton Bán (C) 2024
//
//  This class main aim is to be the entry point for 
//  servecies to handle data. Almost every request
//  will go throw of this calss
// ---------------------------------------------------

namespace LauncherBackend.Repository
{
    class GameDatabaseRepository {
        private GameDataBase gameDataBase = new GameDataBase();
        private bool doesGameDatabaseConnected = false;


        //----------------------------------------------
        //        GameData realated functions 
        //----------------------------------------------
        public void ConnectToGameDataBase(string databaseURL) {
            try {
                gameDataBase.ConnectToGameDataBase(databaseURL);
                this.doesGameDatabaseConnected = true;
            } catch (GameDataBaseConnectionException exp) { 
                Console.WriteLine("Cannot Connect to the database!");
            }
        }

        public void InsertGame(GameDataDTO game) {
            if (doesGameDatabaseConnected) {
                gameDataBase.InsertGame(game);
                Console.WriteLine("Game Has Been Added!" + game.GameTitle);
            } else {
                throw new GameDataBaseConnectionException("Database in not connected, please connect to the database! Use: GameController::ConnectToGameDataBase(string url) function");
            }
            
        }

        public List<GameDataDTO> GetAllGames() {
            if (doesGameDatabaseConnected) {
                return gameDataBase.GetAllGames();
            } else {
                throw new GameDataBaseActionException();
            }
        }
    }
}
