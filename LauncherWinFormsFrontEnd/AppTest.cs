using LauncherBackend.Controller;
using LauncherWinFormsFrontEnd.BackendConnector;
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

namespace LauncherWinFormsFrontEnd {
    public partial class AppTest : Form {

        App currentApp;
        Backend backend = new Backend();

        public AppTest() {
            InitializeComponent();
        }

        private void AppTest_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            int id = int.Parse(textBox1.Text);
            currentApp = backend.GetAppByID(id);
            label1.Text = currentApp.Id.ToString();
            label2.Text = currentApp.AppName;
        }

        private void button2_Click(object sender, EventArgs e) {
            string folderpath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            DialogResult dr = fbd.ShowDialog();

            if (dr == DialogResult.OK) {
                folderpath = fbd.SelectedPath;
            }

            if (folderpath != "") {
                label12.Text = folderpath;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (label1.Text != "label1" && label12.Text != "label12") {
                backend.InstallApp(currentApp, label12.Text);
            }
        }
    }
}
