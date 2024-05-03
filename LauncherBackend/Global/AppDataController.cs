using LauncherBackend.Databases;
using LauncherBackend.Exceptions;
using LauncherBackend.Modells;
using LauncherBackend.Models;

namespace LauncherBackend.Global {
    public static class AppDataController {
        private static AppDataSaver? appDataSaver;

        public static void AttachAppdataSaver(AppDataSaver saver) {

            if (appDataSaver != null) {
                throw new AppDataSaverHasBeenAttachedToTheControllerException(
                        "Error: AppDataSaver already attached to the Controller!"
                    );
            } else {
                appDataSaver = saver;
            }

            try {
                CanWeUseAppDataSaver();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool GameInstalled(GameDataDTO game, string path) {          
            try {
                GameInstalledSaved(game, path);
                return true;
            } catch (Exception exp) { 
                Console.WriteLine(exp.Message);
                return false;
            }
        }

        public static bool AppInstalled(AppDTO app, string path) {
            try {
                AppInstalledSaved(app, path);
                return true;
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
                return false;
            }
        }

        public static bool BagProjectAdded(BagProjectDTO project) {
            try {
                BagProjectAddedSaved(project);
                return true;
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
                return false;
            }
        }


        //---------------------------
        // Helper Funcions for Games
        //---------------------------
        private static void GameInstalledSaved(GameDataDTO game, string path) {
            GameModel model = new GameModel {
                GameDataDTO = game,
                InstallationPath = path
            };

            if (!FileSystemService.IsPathExist(path)) {
                throw new CannotInstallAppException(
                        "Error: The given Installation path is invalid!"
                    );
            }

            try {
                CanWeUseAppDataSaver();
            } catch (Exception) {
                throw;
            }

            try {
                appDataSaver.SaveGame(model);   
            } catch (Exception) {
                throw;
            }
            
        }

        //---------------------------
        // Helper Funcions for Apps
        //---------------------------
        private static void AppInstalledSaved(AppDTO app, string path) {
            AppModel model = new AppModel{
                App = app,
                InstallationPath = path
            };

            if (!FileSystemService.IsPathExist(path)) {
                throw new CannotInstallAppException(
                        "Error: The given Installation path is invalid!"
                    );
            }

            try {
                CanWeUseAppDataSaver();
            } catch (Exception) {
                throw;
            }

            try {
                appDataSaver.SaveApp(model);
            } catch (Exception) {
                throw;
            }

        }

        //-----------------------------------
        //  Helper Funcions for BagProject
        //-----------------------------------
        private static void BagProjectAddedSaved(BagProjectDTO project) {

            if (!FileSystemService.IsPathExist(project.InstallationPath)) {
                throw new CannotInstallAppException(
                        "Error: The given Installation path is invalid!"
                    );
            }

            try {
                CanWeUseAppDataSaver();
            } catch (Exception) {
                throw;
            }

            try {
                appDataSaver.SaveBagProject(project);
            } catch (Exception) {
                throw;
            }
        }


        //---------------------------
        //     Awareness Check
        //---------------------------
        private static void CanWeUseAppDataSaver() {
            if (appDataSaver == null) {
                throw new AppDataSaverNotAttachedToTheControllerException(
                        "Error: AppDataSaver instance not yet attached to the AppDataController!"
                    );
            }

            if (!appDataSaver.GetStatus()) {
                throw new AppDataSaverHasBennNotActivated(
                        "Error: AppDataSaver has been not activatied yet! Please Activate it before usege!"
                    );
            }
        }
    }
}
