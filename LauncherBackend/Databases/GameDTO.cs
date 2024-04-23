using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// --------------------------------------------------
//              Launcher - GameDTO
//              Márton Bán (C) 2024
//  
//  This is the GameModell DTO object for the Launcher's
//  backend. This class contain the metadata for each game 
//---------------------------------------------------

namespace LauncherBackend.Database
{
    public class GameDTO
    {
        public string? GameTitle { get; set; }
        public string? Description { get; set; }
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        public string? IconPath { get; set; }
        public string? ThumbnailPath { get; set; }
        public string? FTPFolderPath { get; set; }
        public string? FileName { get; set; }
    }
}
