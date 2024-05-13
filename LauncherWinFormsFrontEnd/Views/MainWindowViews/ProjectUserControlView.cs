using LauncherBackend.Models;
using LauncherWinFormsFrontEnd.Models;
using LauncherWinFormsFrontEnd.Views.ContentUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWinFormsFrontEnd.Views.MainWindowViews {
    public partial class ProjectUserControlView : UserControl {
        public ProjectUserControlView() {
            InitializeComponent();
        }

        private void ProjectUserControlView_Load(object sender, EventArgs e) {
            List<BagProjectDTO> projects = MainWindowView.backend.appDataSaver.GetBagProjectsFromAppData();
            List<UserControl> userControls = new List<UserControl>();

            foreach (BagProjectDTO project in projects) {
                BagProject bagProject = ProjectConverter.BagProjectDTOToBagProject(project);
                ProjectTileView projectTileView = new ProjectTileView(bagProject);
                userControls.Add(projectTileView);
            }

            foreach (UserControl uc in userControls) {
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            ProjectWizardView projectWizardView = new ProjectWizardView();
            projectWizardView.Show();
        }
    }
}
