using System.Text.Json;

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
        private List<GameDTO> gameDataBase = new List<GameDTO>();

        public GameDataBase(string databasePath)
        {
            this.databaseFullPath = databasePath + "/games_libary.json";
            if (CheckFileIsExist(this.databaseFullPath))
            {
                Deserialize(this.databaseFullPath);
            }
            else
            {

            }
        }

        public void InsertGame(GameDTO gameDTO)
        {
            gameDataBase.Add(gameDTO);
            Serialize();
        }

        public List<GameDTO> GetAllGames()
        {
            return gameDataBase;
        }


        //---------------------------------
        //       (De)Serialization
        //---------------------------------
        private void Deserialize(string ftpPath)
        {
            var serializationJson = File.ReadAllText(ftpPath);
            gameDataBase = JsonSerializer.Deserialize<List<GameDTO>>(serializationJson);
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
