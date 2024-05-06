using LauncherBackend.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherWinFormsFrontEnd.Models {
    public static class GameConverter {
        public static Game GameDTOToGameConverter(GameDataDTO dto) {
            string URL = LauncherBackend.Global.FTP.GetRoot();
            return new Game {
                Id = dto.Id,
                GameTitle = dto.GameTitle,
                Description = dto.Description,
                Developer = dto.Developer,
                Publisher = dto.Publisher,
                FTPFolderPath = URL + dto.FTPFolderPath,
                FileName = dto.FileName,
                IconPath = URL + dto.IconPath,
                ThumbnailPath = URL + dto.ThumbnailPath
            };
        }
    }
}