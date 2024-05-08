using LauncherBackend.Global;
using LauncherBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Controller {
    public class ProjectController {
    
        public ProjectController() { }

        public void BagProjectWizard(BagProjectDTO project) {
            bool wizardFlag = false;
            bool savedFalg = false;
            
            try {
                BagWizard(project);
                wizardFlag = true;
            } catch (Exception exp) {
                SignalSystem.ErrorHappend(exp, SignalSystem.ErrorWarning);
                wizardFlag = false;
            }

            if (AppDataController.BagProjectAdded(project)) {
                savedFalg = true;
            }

            if (savedFalg && wizardFlag) {
                Console.WriteLine("DONE!!!");
            }   
        }
    
        private void BagWizard(BagProjectDTO project) {
            FileSystemService.InstallBagProject(project);
        }
    
    }
}
