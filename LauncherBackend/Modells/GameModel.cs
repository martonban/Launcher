using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------------------
//              Launcher - GameModel
//              Márton Bán (C) 2024
//  
//  This is the GameModell. This calss will used by
//  the AppStatus subsystem.
//---------------------------------------------------

namespace LauncherBackend.Modells {
    public class GameModel {
        public GameDataDTO? GameDataDTO { get; set; }
        public string? InstallationPath { get; set; }
    }
}
