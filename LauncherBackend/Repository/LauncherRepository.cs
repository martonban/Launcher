using LauncherBackend.DTOs;
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
//  the databases or store the application's current status.
//  --------------------------------------------------

namespace LauncherBackend.Repository
{
    class LauncherRepository {
        private GameDataBase gameDataBase;
        private bool gameDataInit = false;

        //private AppStaus appStaus;

        public LauncherRepository() { }


        //----------------------------------------------
        //        GameData realated functions 
        //----------------------------------------------
        public void ConnectGameDatabase(string ftpFilePath) {
            try {
                this.gameDataBase = new GameDataBase(ftpFilePath);
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
