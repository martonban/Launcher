using LauncherBackend.Exceptions;
using LauncherBackend.Modells;
using LauncherBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LauncherBackend.Databases {
    public class ApplicationDataBase {
        // Data Fileds
        private string databaseFullPath;
        private List<AppDTO> applicationDataBase = new List<AppDTO>();

        public void ConnectToApplicationDataBase(string databasePath) {
            this.databaseFullPath = databasePath + "/application_libary.json";
            if (!CheckFileIsExist(this.databaseFullPath)) {
                throw new ApplicationDataBaseConnectionException(
                    "Error: Application Databas is not existed!"
                );
            }
            Console.WriteLine("Works!");
        }

        public void InsertApplication(AppDTO appDTO) {
            int idCheck = (int)appDTO.Id;
            try {
                AppDTO temp = GetAppByID(idCheck);
                if (temp.Id != null) {
                    throw new AppIsExistsInTheDataBaseWithThisIDExeption("This application is already exists in the database already!");
                }
            } catch (AppIsNotExistedInTheDatabaseException exp) {
                applicationDataBase.Add(appDTO);
                Serialize();
            }
        }

        public AppDTO GetAppByID(int requestedId) {
            Refresh();
            foreach (var app in applicationDataBase) {
                if (app.Id == requestedId) {
                    return app;
                }
            }
            throw new AppIsNotExistedInTheDatabaseException("This ID is not exists int the current database!");
        }


        public List<AppDTO> GetAllApplications() {
            Refresh();
            return applicationDataBase;
        }


        //---------------------------------
        //       (De)Serialization
        //---------------------------------
        private void Deserialize(string ftpPath) {
            var serializationJson = File.ReadAllText(ftpPath);
            try {
                applicationDataBase = JsonSerializer.Deserialize<List<AppDTO>>(serializationJson);
            } catch (JsonException exp) {
                Console.WriteLine("ERROR!!!!! DEV NOTE: A Json fájlban nincsen: '[]'. Pótold és jó lesz!");
            }
        }

        private void Serialize() {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(applicationDataBase, option);
            File.WriteAllText(databaseFullPath, jsonString);
        }


        //---------------------------------
        //       Helper Functions
        //---------------------------------
        private void Refresh() {
            applicationDataBase.Clear();
            Deserialize(databaseFullPath);
        }


        private bool CheckFileIsExist(string path) {
            if (File.Exists(path)) {
                return true;
            } else {
                return false;
            }
        }
    }
}
