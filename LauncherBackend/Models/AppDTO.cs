﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Models {
    public class AppDTO {
        public string? AppName { get; set; }
        public string? Description { get; set; }
        public string? Suit { get; set; }
        public string? Version { get; set; }
        // Installation Data on the FTP File System
        public string? FTPFolderPath { get; set; }
        public string? FileName { get; set; }
        // Media files on the FTP
        public string? IconPath { get; set; }
        public string? CoverPath { get; set; }
    }
}