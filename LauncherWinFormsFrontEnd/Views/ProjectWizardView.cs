using LauncherBackend.Models;
using LauncherWinFormsFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWinFormsFrontEnd.Views {
    public partial class ProjectWizardView : Form {
        public ProjectWizardView() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string folderpath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            DialogResult dr = fbd.ShowDialog();

            if (dr == DialogResult.OK) {
                folderpath = fbd.SelectedPath;
            }

            if (folderpath != "") {
                textBox2.Text = folderpath;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Debug.WriteLine(textBox2.Text);
            if (textBox1.Text != "" && comboBox1.Text != "" &&
                Directory.Exists(textBox2.Text)) {
                BagProject projectDTO = new BagProject {
                    ProjectTitle = textBox1.Text,
                    Suite = comboBox1.Text,
                    InstallationPath = textBox2.Text
                };
                MainWindowView.backend.CreateBagProject(projectDTO);
                string title = "Sucess";
                string message = "Installation is sucsessful!";
                MessageBox.Show(message, title);
                this.Hide();
            } else {
                string title = "Wrong!";
                string message = "Installation Path is not exists!";
                MessageBox.Show(message, title);
            }
        }
    }
}
