using LauncherBackend.Global;
using LauncherBackend.Models;

namespace LauncherWinFormsFrontEnd.Models {
    public static class AppConverter {
        public static App AppDTOToAppCoverter(AppDTO dto) {
            string URL = FTP.GetRoot();
            return new App {
                Id = dto.Id,
                AppName = dto.AppName,
                Description = dto.Description,
                Suite = dto.Suite,
                Version = dto.Version,
                FTPFolderPath = dto.FTPFolderPath,
                FileName = dto.FileName,
                IconPath = dto.IconPath,
                CoverPath = dto.CoverPath,
                CurrentFTPPath = URL,
            };
        }

        public static AppDTO AppToAppDTOConverter(App app) {
            return new AppDTO {
                Id = app.Id,
                AppName = app.AppName,
                Description = app.Description,
                Suite = app.Suite,
                Version = app.Version,
                FTPFolderPath = app.FTPFolderPath,
                FileName = app.FileName,
                IconPath = app.IconPath,
                CoverPath = app.CoverPath
            };
        }

        public static App AppModelToAppConverter(AppModel model) {
            return new App {
                Id = model.App.Id,
                AppName = model.App.AppName,
                Description = model.App.Description,
                Suite = model.App.Suite,
                Version = model.App.Version,
                FTPFolderPath = model.App.FTPFolderPath,
                FileName = model.App.FileName,
                IconPath = model.App.IconPath,
                CoverPath = model.App.CoverPath,
                CurrentFTPPath = FTP.GetRoot(),
                InstallationPath = model.InstallationPath
            };
        }

    }
}
