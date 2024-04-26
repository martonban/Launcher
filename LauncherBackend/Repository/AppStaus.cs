using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LauncherBackend.Database;
using LauncherBackend.DTOs;

// --------------------------------------------------
//              Launcher - AppStaus
//              Márton Bán (C) 2024
//
//  The main responsibility for the class is to keep
//  track of the Launcher's status, like how many apps,
//  games, assetes or project has been used by the user 
// --------------------------------------------------

namespace LauncherBackend.Repository
{
    public class AppStaus {

        private string userAppDataPath;

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
                GameListInit();
                AppListInit();
                ProjectListInit();
            }
        }

        //------------------------------
        // Constructor Helper Functions
        //------------------------------

        private void GameListInit() {
            string filePath = userAppDataPath + "/gamelist.json";
            if (File.Exists(filePath) && (gameList.Count == 0)) {
                // TODO: Deserialize
            } else if(!File.Exists(filePath) && (gameList.Count != 0)) { 
                // TODO: Serialize
            }   
        }

        private void AppListInit() {
            string filePath = userAppDataPath + "/applist.json";
            if (File.Exists(filePath) && (appList.Count == 0)) {
                // TODO: Deserialize
            } else if (!File.Exists(filePath) && (appList.Count != 0)) {
                // TODO: Serialize
            }
        }

        private void ProjectListInit() {
            string filePath = userAppDataPath + "/projectlist.json";
            if (File.Exists(filePath) && (projectList.Count == 0)) {
                // TODO: Deserialize
            } else if (!File.Exists(filePath) && (projectList.Count != 0)) {
                // TODO: Serialize
            }
        }
    }
}
