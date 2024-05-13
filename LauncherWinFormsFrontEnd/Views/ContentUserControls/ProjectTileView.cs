using LauncherWinFormsFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWinFormsFrontEnd.Views.ContentUserControls {
    public partial class ProjectTileView : UserControl {

        private BagProject bagProject;

        public ProjectTileView(BagProject project) {
            InitializeComponent();
            bagProject = project;
        }

        private void ProjectTileView_Load(object sender, EventArgs e) {
            label1.Text = bagProject.ProjectTitle;
            label2.Text = bagProject.Suite;
            label3.Text = bagProject.InstallationPath;
        }

        private void button1_Click(object sender, EventArgs e) {
        }
    }
}
