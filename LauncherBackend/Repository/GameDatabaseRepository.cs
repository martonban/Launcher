using LauncherBackend.Database;
using LauncherBackend.Exceptions;
using LauncherBackend.Modells;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                Debug.WriteLine("Game Database Connection was SUCCESFULL!");
            } catch (GameDataBaseConnectionException exp) { 
                Debug.WriteLine("Cannot Connect to the database!");
            }
        }

        public GameDataDTO GetGameByIDFromTheDatabase(int id) {
            if (doesGameDatabaseConnected) {
                try {
                    return gameDataBase.GetGameByID(id);
                } catch (GameIsNotExistedInTheDatabaseException exp) {
                    Console.WriteLine(exp.Message);
                } 
            }
            else {
                throw new GameDataBaseConnectionException("Database in not connected, please connect to the database! Use: GameController::ConnectToGameDataBase(string url) function!");
            }
            return new GameDataDTO();
        }

        public void InsertGame(GameDataDTO game) {
            if (doesGameDatabaseConnected) {
                try {
                    gameDataBase.InsertGame(game);
                } catch (GameIsExistsInTheDataBaseWithThisIDExeption exp) {
                    Console.WriteLine(exp.Message);
                }  
            } else {
                throw new GameDataBaseConnectionException("Database in not connected, please connect to the database! Use: GameController::ConnectToGameDataBase(string url) function!");
            }
            
        }

        public List<GameDataDTO> GetAllGames() {
            if (doesGameDatabaseConnected) {
                return gameDataBase.GetAllGames();
            } else {
                throw new GameDataBaseConnectionException("Database in not connected, please connect to the database! Use: GameController::ConnectToGameDataBase(string url) function!");
            }
        }
    }
}
