using LauncherBackend.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// --------------------------------------------------
//          Launcher - LauncherRepository
//              Márton Bán (C) 2024
//
//  ftpPath: Currently just a folder local machine to
//  data such as pictures and application data files
//  
//  
//
// --------------------------------------------------

namespace LauncherBackend.Repository
{
    class GameDataBase {
        // Data Fileds
        private string ftpPath;
        private List<GameDTO> gameDataBase = new List<GameDTO>();

        public GameDataBase(String ftpPath) {
            this.ftpPath = ftpPath;
            string fullPath = this.ftpPath + "/games_libary.json";
            if (CheckFileIsExist(fullPath)) {
                Deserialize(fullPath);
            } else {
                throw new DataBaseConnectionException();
            }
        }

        public void InsertGame(GameDTO gameDTO) {
            gameDataBase.Add(gameDTO);
            Serialize();
        }

        public List<GameDTO> GetAllGames() {
            return gameDataBase;
        }


        //---------------------------------
        //       (De)Serialization
        //---------------------------------
        private void Deserialize(string ftpPath) {
            // TODO Deserialziation
        }

        private void Serialize() {
            // TODO Serialize
        }


        //---------------------------------
        //       Helper Functions
        //---------------------------------
        private bool CheckFileIsExist(string path) {
            if (File.Exists(path)) {
                return true;
            } else {
                return false;
            }
        }
    }
}
