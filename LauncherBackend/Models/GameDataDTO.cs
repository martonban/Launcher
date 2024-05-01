using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// --------------------------------------------------
//              Launcher - GameDataDTO
//              Márton Bán (C) 2024
//  
//  This is the GameDataDTO object for the database 
//  to store the game informations and the place on the
//  FTP server. We are gonna use this data DTO in the
//  client modell
//---------------------------------------------------

namespace LauncherBackend.Modells {
    public class GameDataDTO {
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
    }
}
