using LauncherBackend.Modells;
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

namespace LauncherWinFormsFrontEnd.Views {
    public partial class InstallGameView : Form {

        private Game game;
        private string path;

        public InstallGameView(Game game) {
            this.game = game;
            InitializeComponent();
        }

        private void InstallGameView_Load(object sender, EventArgs e) {
            label2.Text = game.GameTitle;
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
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

        private void button2_Click(object sender, EventArgs e) {
            if (Directory.Exists(textBox1.Text)) {
                GameDataDTO gameDataDTO = GameConverter.GameToGameDataDTOConerter(game);
                MainWindowView.backend.gameController.InstallGame(gameDataDTO, textBox1.Text);
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
