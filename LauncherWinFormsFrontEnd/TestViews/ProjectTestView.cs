using LauncherWinFormsFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWinFormsFrontEnd.TestViews {
    public partial class ProjectTestView : Form {

        BackendConnector.Backend backend = new BackendConnector.Backend();

        public ProjectTestView() {
            InitializeComponent();
        }

        private void ProjectTestView_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            List<BagProject> projects = backend.GetAllBagProjects();
            foreach (BagProject project in projects) {
                Debug.WriteLine(project.ProjectTitle);
                Debug.WriteLine(project.InstallationPath);
                Debug.WriteLine(project.Suite);
                Debug.WriteLine("-----------------------------");

            }

        }

        private void button3_Click(object sender, EventArgs e) {
            string folderpath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            DialogResult dr = fbd.ShowDialog();

            if (dr == DialogResult.OK) {
                folderpath = fbd.SelectedPath;
            }

            if (folderpath != "") {
                label1.Text = folderpath;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (label1.Text != "label1" && textBox1.Text != null && comboBox1.Text != null) {
                BagProject bagProject = new BagProject {
                    ProjectTitle = textBox1.Text,
                    InstallationPath = label1.Text,
                    Suite = comboBox1.Text,
                };
                backend.CreateBagProject(bagProject);
            }
        }
    }
}
