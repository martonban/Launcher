using LauncherBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherWinFormsFrontEnd.Models {
    public static class ProjectConverter {

        public static BagProject BagProjectDTOToBagProject(BagProjectDTO project) {
            return new BagProject {
                ProjectTitle = project.ProjectTitle,
                InstallationPath = project.InstallationPath,
                Suite = project.Suite
            };
        }

        public static BagProjectDTO BagProjectToBagProjectDTO(BagProject project) {
            return new BagProjectDTO {
                ProjectTitle = project.ProjectTitle,
                InstallationPath = project.InstallationPath,
                Suite = project.Suite
            };
        }

    }
}
