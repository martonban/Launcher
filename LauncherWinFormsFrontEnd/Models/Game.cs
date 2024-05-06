using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherWinFormsFrontEnd.Models {
    public class Game {
        public int? Id { get; set; }
        public string? GameTitle { get; set; }
        public string? Description { get; set; }
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        // Installation Data
        public string? FTPFolderPath { get; set; }
        public string? FileName { get; set; }
        // Media Data
        public string? IconPath { get; set; }
        public string? ThumbnailPath { get; set; }

        public string? CurrentFtpPath { get; set; }
    }
}
