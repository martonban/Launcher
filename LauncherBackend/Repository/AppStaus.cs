using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LauncherBackend.DTOs;

// --------------------------------------------------
//              Launcher - AppStaus
//              Márton Bán (C) 2024
//
//  The main responsibility for the class is to keep
//  track of the Launcher's status, like how many apps,
//  games, assetes or project has been used by the user 
// --------------------------------------------------

namespace LauncherBackend.Repository
{
    public class AppStaus {

        private string userAppDataPath;

        private Dictionary<string, ProjectDTO> projectList =
                new Dictionary<string, ProjectDTO>();
       

    }
}
