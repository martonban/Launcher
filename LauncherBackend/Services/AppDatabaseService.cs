using LauncherBackend.Exceptions;
using LauncherBackend.Models;
using LauncherBackend.Repository;

namespace LauncherBackend.Services {
    public class AppDatabaseService {
        private AppDatabaseRepository applicationDatabaseRepository = new AppDatabaseRepository();

        public void ConnectToApplicationDataBase(string url) {
            applicationDatabaseRepository.ConnectToApplicationDataBase(url);
        }

        public AppDTO GetApplicationByIDFromTheDatabase(int id) {
            try {
                return applicationDatabaseRepository.GetApplicationByIDFromTheDatabase(id);
            } catch (ApplicationDataBaseConnectionException exp) {
                Console.WriteLine(exp.Message);
                return new AppDTO();
            }
        }

        public void InsertApp(AppDTO app) {
            try {
                applicationDatabaseRepository.InsertApp(app);
            } catch (ApplicationDataBaseConnectionException exp) {
                Console.WriteLine(exp.Message);
            }
        }

        public List<AppDTO> GetAllAppsFromDatabase() {
            try {
                return applicationDatabaseRepository.GetAllApps();
            } catch (ApplicationDataBaseConnectionException exp) {
                Console.WriteLine(exp.Message);
            }
            return new List<AppDTO>();
        }
    }
}
