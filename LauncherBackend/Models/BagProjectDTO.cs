using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*   ToolUsed data filed is representing wich tool has been used by the project 
*   0 - Bag Project
*   1 - Composer 
*   2 - Asset Packer
*/


namespace LauncherBackend.Models {
    public class BagProjectDTO {
        public string? ProjectTitle { get; set; }
        public string? InstallationPath { get; set; }
        // Tool attached
        public List<bool>? ToolUsed { get; set; }
    }
}
