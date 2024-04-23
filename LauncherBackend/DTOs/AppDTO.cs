using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.DTOs
{
    public class AppDTO {
        public string? AppName { get; set; }
        public string? IconImagePath { get; set; }
        public string? CoverImagePath { get; set; }
        public string? FTPFolderPath { get; set; }
        public string? FileName { get; set; }
    }
}
