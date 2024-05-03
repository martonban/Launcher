using LauncherBackend.Global;
using LauncherBackend.Modells;
using LauncherBackend.Models;
using LauncherBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Controller {
    public class AppController {
        private AppDatabaseService appDataService = new AppDatabaseService();

        //-----------------------------
        // AppDataBase Service Calls
        //-----------------------------
        public void ConnectToApplicationDataBase(string url) {
            appDataService.ConnectToApplicationDataBase(url);
        }

        public void InsertApplicationToTheDatabase(AppDTO app) {
            appDataService.InsertApp(app);
        }

        public AppDTO GetApplicationByIDFromTheDatabase(int id) {
            return appDataService.GetApplicationByIDFromTheDatabase(id);
        }

        public List<AppDTO> GetAllApplicationsFromDatabase() {
            return appDataService.GetAllAppsFromDatabase();
        }


        //-----------------------------
        //  Installation Service Calls
        //-----------------------------
        public void InstallApp(AppDTO app, string installationPath) {
            // Install the app
            try {
                FileSystemService.InstallApp(app, installationPath);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            //Administrate the game has been installed
            if (AppDataController.AppInstalled(app, installationPath)) {
                Console.WriteLine("Game has been istalled and saved!");
            }
        }
    }
}
