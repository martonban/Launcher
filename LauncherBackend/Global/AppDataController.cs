using LauncherBackend.Databases;
using LauncherBackend.Exceptions;
using LauncherBackend.Modells;

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

        // ITS NOT GOOD
        public static bool GameUninstalled(string path) {
            try {
                GameUninstalledSaved(path);
                return true;
            } catch(Exception exp) {
                Console.WriteLine(exp.Message);
                return false;
            }
        }


        //---------------------------
        // Helper Funcions for games
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

        private static void GameUninstalledSaved(string path) { 
            
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
