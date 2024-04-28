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
            gameDataBase.Add(gameDTO);
            Serialize();
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
            gameDataBase = JsonSerializer.Deserialize<List<GameDataDTO>>(serializationJson);
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
