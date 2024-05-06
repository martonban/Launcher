using LauncherBackend.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LauncherWinFormsFrontEnd.Models {
    public static class GameConverter {
        public static Game GameDTOToGameConverter(GameDataDTO dto) {
            return new Game {
                Id = dto.Id,
                GameTitle = dto.GameTitle,
                Description = dto.Description,
                Developer = dto.Developer,
                Publisher = dto.Publisher,
                FTPFolderPath = dto.FTPFolderPath,
                FileName = dto.FileName,
                IconPath = dto.IconPath,
                ThumbnailPath = dto.ThumbnailPath,
                CurrentFtpPath = LauncherBackend.Global.FTP.GetRoot()
        };
        }

        public static GameDataDTO GameToGameDataDTOConerter(Game game) {
            return new GameDataDTO {
                Id = game.Id,
                GameTitle = game.GameTitle,
                Description = game.Description,
                Developer = game.Developer,
                Publisher = game.Publisher,
                FTPFolderPath = game.FTPFolderPath,
                FileName = game.FileName,
                IconPath = game.IconPath,
                ThumbnailPath =  game.ThumbnailPath
            };
        }
    }
}