using LauncherBackend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.DTOs
{
    public class ProjectDTO {
        public string? ProjectName { get; set; }
        public string? ProjectPath { get; set; }
        public string? AppType { get; set; }
    }
}
