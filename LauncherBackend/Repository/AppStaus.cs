using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LauncherBackend.Database;
using LauncherBackend.DTOs;

// --------------------------------------------------
//              Launcher - AppStaus
//              Márton Bán (C) 2024
//
//  The main responsibility for the class is to keep
//  track of the Launcher's status, like how many apps,
//  games or project has been used/install by the user 
// --------------------------------------------------

namespace LauncherBackend.Repository
{
    public class AppStaus {

        private string userAppDataPath;
        private string gameListFilePath;
        private string appListFilePath;
        private string projectListFilePath;

        private Dictionary<string, GameDTO> gameList =
                 new Dictionary<string, GameDTO>();
        private Dictionary<string, AppDTO> appList =
                new Dictionary<string, AppDTO>();
        private List<ProjectDTO> projectList = 
                new List<ProjectDTO>();

        public AppStaus() {
            string statusPath = Directory.GetCurrentDirectory() + "/status";
            // Check App Status Path 
            if (Directory.Exists(statusPath)) {
                this.userAppDataPath = statusPath;
                this.gameListFilePath = userAppDataPath + "/gamelist.json";
                this.appListFilePath = userAppDataPath + "/applist.json";
                this.projectListFilePath = userAppDataPath + "/projectlist.json";
                GameListInit();
                AppListInit();
                ProjectListInit();
            }
        }

        //------------------------------
        // Constructor Helper Functions
        //------------------------------
        private void GameListInit() {
            if (File.Exists(gameListFilePath) && (gameList.Count == 0)) {
                DeserializeGame();
            } else if(!File.Exists(gameListFilePath) && (gameList.Count != 0)) {
                SerilazeGame(gameList);
            }   
        }

        private void AppListInit() {
            if (File.Exists(appListFilePath) && (appList.Count == 0)) {
                DeserializeApps();
            } else if (!File.Exists(appListFilePath) && (appList.Count != 0)) {
                SerilazeApp(appList);
            }
        }

        private void ProjectListInit() {
            if (File.Exists(projectListFilePath) && (projectList.Count == 0)) {
                DeserializeProjects();
            } else if (!File.Exists(projectListFilePath) && (projectList.Count != 0)) {
                SerilazeProject(projectList);
            }
        }

        //-----------------------
        //        Setters
        //-----------------------
        public void AddGame(string installPath, GameDTO game) {
            gameList.Add(installPath, game);
        }

        public void RemoveGame(string installPath) {
            gameList.Remove(installPath);
        }

        public void AddApp(string installPath, AppDTO app) {
            appList.Add(installPath, app);
        }

        public void RemoveApp(string installPath) {  
            appList.Remove(installPath); 
        }

        public void AddProject(ProjectDTO project) { 
            projectList.Add(project);
        }

        public void RemoveProject(ProjectDTO project) {  
            projectList.Remove(project); 
        }

        //-----------------------
        //        Setters
        //-----------------------
        public Dictionary<string, GameDTO> GetAllGames() {
            return null;
        }

        public Dictionary<string, AppDTO> GetAllApps() {
            return null;
        }

        public List<ProjectDTO> GetAllProjects() {
            return null;
        }


        //--------------------------------
        //         Serializers
        //--------------------------------
        public void SerilazeGame(Dictionary<string, GameDTO> gameList) {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(gameList, option);
            File.WriteAllText(gameListFilePath, jsonString);
        }

        public void SerilazeApp(Dictionary<string, AppDTO> appList) {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(appList, option);
            File.WriteAllText(appListFilePath, jsonString);
        }

        public void SerilazeProject(List<ProjectDTO> projectList) {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(projectList, option);
            File.WriteAllText(projectListFilePath, jsonString);
        }

        //--------------------------------
        //         Deserializers
        //--------------------------------
        public void DeserializeGame() {
            var serializationJson = File.ReadAllText(gameListFilePath);
            gameList = JsonSerializer.Deserialize<Dictionary<string, GameDTO>>(serializationJson);
        }

        public void DeserializeApps() {
            var serializationJson = File.ReadAllText(appListFilePath);
            appList = JsonSerializer.Deserialize<Dictionary<string, AppDTO>>(serializationJson);
        }

        public void DeserializeProjects() {
            var serializationJson = File.ReadAllText(projectListFilePath);
            projectList = JsonSerializer.Deserialize<List<ProjectDTO>>(serializationJson);
        }
    }
}
