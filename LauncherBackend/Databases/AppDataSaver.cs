using LauncherBackend.Database;
using LauncherBackend.Exceptions;
using LauncherBackend.Global;
using LauncherBackend.Modells;
using LauncherBackend.Models;
using System.Text.Json;

namespace LauncherBackend.Databases {
    public class AppDataSaver {
        private List<GameModel> games = new List<GameModel>();
        private List<AppModel> apps = new List<AppModel>();
        private List<BagProjectDTO> bagprojects = new List<BagProjectDTO>();

        private bool activated = false;
        private string rootURL;
        private const string gamesURLSufix = "\\GamesAppdata.json"; 
        private const string appsURLSufix = "\\AplicationsAppdata.json"; 
        private const string bagProjectsURLSufix = "\\BagProjectsAppdata.json";


        //---------------------------------------------------------------------
        //                          Initialize Functions
        //---------------------------------------------------------------------
        public AppDataSaver() { }

        public void Activate() {
            string path = Directory.GetCurrentDirectory() + "\\appdata";
            bool directoryIsReady = false;
            bool gamesAreReady = false;
            bool applicationsAreReady = false;
            bool bagProjectsAreReady = false;

            if (IsAppDataDirectoryExists(path)) {
                directoryIsReady = true;
            }

            if (IsGameDataExist(path)) {
                gamesAreReady = true;
            }

            if (IsApplicationDataExist(path)) {
                applicationsAreReady = true;
            }

            if (IsBagProjectsDataExist(path)) {
                bagProjectsAreReady = true;
            }

            if (directoryIsReady && gamesAreReady && applicationsAreReady 
                    && bagProjectsAreReady) {
                activated = true;
                rootURL = path;
                RefreshEverythig();
            }
        }

        //---------------------------------------------------------------------
        //                    Activation Function's Helpers
        //---------------------------------------------------------------------
        public bool IsAppDataDirectoryExists(string path) {
            if (FileSystemService.IsPathExist(path)) {
                return true;
            } else {
                Directory.CreateDirectory(path);
                return true;
            }
        }

        private bool IsGameDataExist(string path) {
            if (File.Exists(path + gamesURLSufix)) {
                return true;
            } else {
                File.Copy(Assets.Files.File1, path + gamesURLSufix);
                return true;
            }
        }

        private bool IsApplicationDataExist(string path) {
            if (File.Exists(path + appsURLSufix)) {
                return true;
            } else {
                File.Copy(Assets.Files.File2, path + appsURLSufix);
                return true;
            }
        }

        private bool IsBagProjectsDataExist(string path) {
            if (File.Exists(path + bagProjectsURLSufix)) {
                return true;
            } else {
                File.Copy(Assets.Files.File3, path + bagProjectsURLSufix);
                return true;
            }
        }

        public void RefreshEverythig() {
            games.Clear();
            apps.Clear();
            bagprojects.Clear();
            DeserializeGames();
            DeserializeApps();
            DeserializeBagProjects();
    }

        //---------------------------------------------------------------------
        //                        Manipulate Data Functions
        //---------------------------------------------------------------------

        public void SaveGame(GameModel model) {
            RefreshGames();
            games.Add(model);
            SerializeGames();
        }

        public void SaveApp(AppModel model) {
            RefreshApps();
            apps.Add(model);
            SerializeApps();
        }

        public void SaveBagProject(BagProjectDTO project) {
            RefreshBagProjects();
            bagprojects.Add(project);
            SerializeBagProjects();
        }

        //---------------------------------------------------------------------
        //                          Helper Functions
        //---------------------------------------------------------------------

        private void TryToRemoveGame(string URL) {
            foreach (GameModel game in games) {
                if (game.InstallationPath == URL) { 
                    games.Remove(game);
                    return;
                }
                throw new ThisGameIsNotExistsException(
                        "Error: No games are installed at this URL!"
                    );
            }
        }

        //---------------------------------------------------------------------
        //                              GETTERS
        //---------------------------------------------------------------------
        public List<GameModel> GetAllGamesFromAppData() {
            return games;
        }

        public List<AppModel> GetAllApplicationFromAppData() {
            return apps;
        }

        public List<BagProjectDTO> GetBagProjectsFromAppData() {
            return bagprojects;
        }

        public bool GetStatus() {
            return activated;
        }

        //---------------------------------------------------------------------
        //                  Serialization Functions - Games
        //---------------------------------------------------------------------
        public void RefreshGames() { 
            games.Clear();
            DeserializeGames();
        }

        public void SerializeGames() {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(games, option);
            File.WriteAllText(rootURL + gamesURLSufix, jsonString);
        }

        public void DeserializeGames() {
            var serializationJson = File.ReadAllText(rootURL + gamesURLSufix);
            try {
                games = JsonSerializer.Deserialize<List<GameModel>>(serializationJson);
            } catch (JsonException exp) {
                Console.WriteLine("ERROR!!!!! DEV NOTE: A Json fájlban nincsen: '[]'. Pótold és jó lesz!");
            }
        }

        //---------------------------------------------------------------------
        //                     Serialization Functions - Apps
        //---------------------------------------------------------------------
        public void RefreshApps() {
            apps.Clear();
            DeserializeApps();
        }

        public void SerializeApps() {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(apps, option);
            File.WriteAllText(rootURL + appsURLSufix, jsonString);
        }

        public void DeserializeApps() {
            var serializationJson = File.ReadAllText(rootURL + appsURLSufix);
            try {
                apps = JsonSerializer.Deserialize<List<AppModel>>(serializationJson);
            } catch (JsonException exp) {
                Console.WriteLine("ERROR!!!!! DEV NOTE: A Json fájlban nincsen: '[]'. Pótold és jó lesz!");
            }
        }

        //---------------------------------------------------------------------
        //                    Serialization Functions - Projects
        //---------------------------------------------------------------------
        public void RefreshBagProjects() {
            bagprojects.Clear();
            DeserializeBagProjects();
        }

        public void SerializeBagProjects() {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(bagprojects, option);
            File.WriteAllText(rootURL + bagProjectsURLSufix, jsonString);
        }

        public void DeserializeBagProjects() {
            var serializationJson = File.ReadAllText(rootURL + bagProjectsURLSufix);
            try {
                bagprojects = JsonSerializer.Deserialize<List<BagProjectDTO>>(serializationJson);
            } catch (JsonException exp) {
                Console.WriteLine("ERROR!!!!! DEV NOTE: A Json fájlban nincsen: '[]'. Pótold és jó lesz!");
            }
        }
    }
}
