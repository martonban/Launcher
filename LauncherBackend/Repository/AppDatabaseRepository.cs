using LauncherBackend.Databases;
using LauncherBackend.Exceptions;
using LauncherBackend.Global;
using LauncherBackend.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Repository {
    public class AppDatabaseRepository {
        private ApplicationDataBase applicationDataBase = new ApplicationDataBase();
        private bool doesApplicationDatabaseConnected = false;


        //----------------------------------------------
        //        GameData realated functions 
        //----------------------------------------------
        public void ConnectToApplicationDataBase(string databaseURL) {
            try {
                applicationDataBase.ConnectToApplicationDataBase(databaseURL);
                this.doesApplicationDatabaseConnected = true;
                Debug.WriteLine("App Database Connection was SUCCESFULL!");
            } catch (ApplicationDataBaseConnectionException exp) {
                SignalSystem.ErrorHappend(exp, SignalSystem.ErrorFatal);
            }
        }

        public AppDTO GetApplicationByIDFromTheDatabase(int id) {
            if (doesApplicationDatabaseConnected) {
                try {
                    return applicationDataBase.GetAppByID(id);
                } catch (AppIsNotExistedInTheDatabaseException exp) {
                    SignalSystem.ErrorHappend(exp, SignalSystem.ErrorExistence);
                }
            } else {
                throw new ApplicationDataBaseConnectionException("Error: Application database in not connected, please connect to the database! Use: ApplicationController::ConnectToApplicationDataBase(string url) function!");
            }
            return new AppDTO();
        }

        public void InsertApp(AppDTO app) {
            if (doesApplicationDatabaseConnected) {
                try {
                    applicationDataBase.InsertApplication(app);
                } catch (AppIsExistsInTheDataBaseWithThisIDExeption exp) {
                    SignalSystem.ErrorHappend(exp, SignalSystem.ErrorExistence);
                }
            } else {
                throw new ApplicationDataBaseConnectionException("Error: Application database in not connected, please connect to the database! Use: ApplicationController::ConnectToApplicationDataBase(string url) function!");
            }

        }

        public List<AppDTO> GetAllApps() {
            if (doesApplicationDatabaseConnected) {
                return applicationDataBase.GetAllApplications();
            } else {
                throw new ApplicationDataBaseConnectionException("Error: Application database in not connected, please connect to the database! Use: ApplicationController::ConnectToApplicationDataBase(string url) function!");
            }
        }
    }
}