using System.ComponentModel;
using System.Text.Json;
using LauncherBackend.Exceptions;
using LauncherBackend.Modells;

// --------------------------------------------------
//              Launcher - GameDataBase
//                Márton Bán (C) 2024
//
//  This class is imitates a real database. The database
//  will store only the meta-data for each game.
// --------------------------------------------------

namespace LauncherBackend.Database
{
    class GameDataBase
    {
        // Data Fileds
        private string databaseFullPath;
        private List<GameDataDTO> gameDataBase = new List<GameDataDTO>();

        public void ConnectToGameDataBase(string databasePath)
        {
            this.databaseFullPath = databasePath + "/games_libary.json";
            if (!CheckFileIsExist(this.databaseFullPath)) {
                throw new GameDataBaseConnectionException();
            }
        }

        public void InsertGame(GameDataDTO gameDTO) {
            Refresh();
            gameDataBase.Add(gameDTO);
            Serialize();
        }

        public GameDataDTO GetGameByID(int requestedId) {
            Refresh();
            foreach (var game in gameDataBase) {
                if (game.Id == requestedId) {
                    return game;
                }
            }
            throw new GameIsNotExistedInTheDatabaseException("This ID is not exists int the current database!");
        }


        public List<GameDataDTO> GetAllGames()
        {
            return gameDataBase;
        }




        //---------------------------------
        //       (De)Serialization
        //---------------------------------
        private void Deserialize(string ftpPath)
        {
            var serializationJson = File.ReadAllText(ftpPath);
            try {
                gameDataBase = JsonSerializer.Deserialize<List<GameDataDTO>>(serializationJson);
            } catch (JsonException exp) {
                Console.WriteLine("ERROR!!!!! DEV NOTE: A Json fájlban nincsen: '[]'. Pótold és jó lesz!");
            }
            
        }

        private void Serialize()
        {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(gameDataBase, option);
            File.WriteAllText(databaseFullPath, jsonString);
        }


        //---------------------------------
        //       Helper Functions
        //---------------------------------
        private void Refresh() {
            gameDataBase.Clear();
            Deserialize(databaseFullPath);
        }


        private bool CheckFileIsExist(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
