using LauncherBackend.Models;
using LauncherWinFormsFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWinFormsFrontEnd.Views {
    public partial class InstallAppView : Form {

        private App app;
        private string path;

        public InstallAppView(App instance) {
            InitializeComponent();
            app = instance;
        }

        private void InstallAppView_Load(object sender, EventArgs e) {
            label2.Text = app.AppName;
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
                path = folderpath;
                textBox1.Text = folderpath;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (Directory.Exists(textBox1.Text)) {
                AppDTO iapp = AppConverter.AppToAppDTOConverter(app);
                MainWindowView.backend.appController.InstallApp(iapp, textBox1.Text);
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
