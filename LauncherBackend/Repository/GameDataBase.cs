using LauncherBackend.DTOs;
using System.Text.Json;

// --------------------------------------------------
//          Launcher - LauncherRepository
//              Márton Bán (C) 2024
//
//  ftpPath: Currently just a folder local machine to
//  data such as pictures and application data files
// --------------------------------------------------

namespace LauncherBackend.Repository
{
    class GameDataBase {
        // Data Fileds
        private string ftpPath;
        private List<GameDTO> gameDataBase = new List<GameDTO>();

        public GameDataBase(String ftpPath) {
            this.ftpPath = ftpPath + "/games_libary.json";
            if (CheckFileIsExist(this.ftpPath)) {
                Deserialize(this.ftpPath);
            } else {

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
            var serializationJson = File.ReadAllText(ftpPath);
            gameDataBase = JsonSerializer.Deserialize<List<GameDTO>>(serializationJson);
        }

        private void Serialize() {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(gameDataBase, option);
            File.WriteAllText(ftpPath, jsonString);
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
