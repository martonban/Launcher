using LauncherBackend.Database;
using LauncherBackend.Exceptions;
using LauncherBackend.Global;
using LauncherBackend.Modells;
using LauncherBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LauncherBackend.Databases {
    public class AppDataSaver {
        // The current data 
        private List<GameModel> games = new List<GameModel>();
        private List<AppDTO> apps = new List<AppDTO>();
        private List<BagProjectDTO> bagprojects = new List<BagProjectDTO>();

        private bool appDataChecked = false;
        private string rootURL = null;
        private const string gamesURLSufix = "/GamesAppdata.json"; 
        private const string appsURLSufix = "/AplicationsAppdata.json"; 
        private const string bagProjectsURLSufix = "/BagProjectsAppdata.json"; 

        public AppDataSaver() { }

        public void Activate() {
            string path = Directory.GetCurrentDirectory() + "/appdata";
            if (FileSystemService.IsPathExist(path)) {
                appDataChecked = true;
                rootURL = path;
                RefreshGames();
                //RefreshApps();
                //RefreshBagProjects();
            } else {
                Directory.CreateDirectory(path);
                appDataChecked = true;
                rootURL = path;
            }
        }

        public bool GetStatus() {
            return appDataChecked;
        }

        public void SaveGame(GameModel model) {
            RefreshGames();
            games.Add(model);
            SerializeGames();
        }

        public void RemoveGames(string URL) {
            RefreshGames();
            try {
                TryToRemoveGame(URL);
            } catch (ThisGameIsNotExistsException exp) { 
                Console.WriteLine(exp.Message);
            }
        }

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

        //------------------------------------
        //  Serialization Functions - Games
        //------------------------------------
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

        //------------------------------------
        //  Serialization Functions - Apps
        //------------------------------------
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
                apps = JsonSerializer.Deserialize<List<AppDTO>>(serializationJson);
            } catch (JsonException exp) {
                Console.WriteLine("ERROR!!!!! DEV NOTE: A Json fájlban nincsen: '[]'. Pótold és jó lesz!");
            }
        }

        //--------------------------------------
        //  Serialization Functions - Projects
        //--------------------------------------
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
