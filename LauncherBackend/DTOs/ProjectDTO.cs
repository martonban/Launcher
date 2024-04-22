using LauncherBackend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.DTOs
{
    public class ProjectDTO {
        public string projectName { get; set; }
        public string engine { get; set; }
        public string app { get; set; }
    }
}
