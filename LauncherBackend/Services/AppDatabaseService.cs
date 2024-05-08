using LauncherBackend.Exceptions;
using LauncherBackend.Global;
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
                SignalSystem.ErrorHappend(exp, SignalSystem.ErrorFatal);
                return new AppDTO();
            }
        }

        public void InsertApp(AppDTO app) {
            try {
                applicationDatabaseRepository.InsertApp(app);
            } catch (ApplicationDataBaseConnectionException exp) {
                SignalSystem.ErrorHappend(exp, SignalSystem.ErrorFatal);
            }
        }

        public List<AppDTO> GetAllAppsFromDatabase() {
            try {
                return applicationDatabaseRepository.GetAllApps();
            } catch (ApplicationDataBaseConnectionException exp) {
                SignalSystem.ErrorHappend(exp, SignalSystem.ErrorFatal);
            }
            return new List<AppDTO>();
        }
    }
}
