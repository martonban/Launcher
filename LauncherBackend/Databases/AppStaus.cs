using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LauncherBackend.DTOs;
using LauncherBackend.Modells;

// --------------------------------------------------
//              Launcher - AppStaus
//              Márton Bán (C) 2024
//
//  The main responsibility for the class is to keep
//  track of the Launcher's status, like how many apps,
//  games or project has been used/install by the user 
// --------------------------------------------------

namespace LauncherBackend.Repository
{
    public class AppStaus {

        string statusPath = Directory.GetCurrentDirectory() + "/status";
    }
}
