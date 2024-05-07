using LauncherWinFormsFrontEnd.BackendConnector;
using LauncherWinFormsFrontEnd.Models;
using System.Diagnostics;

namespace LauncherWinFormsFrontEnd {
    public partial class GameTestView : Form {

        BackendConnector.Backend backend = new BackendConnector.Backend();
        public Game selectedgame;

        public GameTestView() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            int id = Int32.Parse(textBox1.Text);
            selectedgame = backend.GetGameById(id);
            label1.Text = selectedgame.GameTitle;
            label2.Text = selectedgame.FTPFolderPath;
            label3.Text = selectedgame.FileName;
        }

        private void button2_Click(object sender, EventArgs e) {
            List<Game> games = backend.GetAllGames();
            foreach (Game game in games) {
                Debug.WriteLine(game.Id);
                Debug.WriteLine(game.GameTitle);
                Debug.WriteLine(game.Description);
                Debug.WriteLine(game.Developer);
                Debug.WriteLine(game.Publisher);
                Debug.WriteLine(game.FTPFolderPath);
                Debug.WriteLine(game.FileName);
                Debug.WriteLine(game.IconPath);
                Debug.WriteLine(game.ThumbnailPath);
                Debug.WriteLine("------------------");
            }
        }



        private void button4_Click(object sender, EventArgs e) {
            string folderpath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            DialogResult dr = fbd.ShowDialog();

            if (dr == DialogResult.OK) {
                folderpath = fbd.SelectedPath;
            }

            if (folderpath != "") {
                label10.Text = folderpath;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (label1.Text != "label1" && label10.Text != "label10") {
                backend.InstallGame(selectedgame, label10.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            List<Game> games = backend.GetAllInstalledGame();
            foreach (Game game in games) {
                Debug.WriteLine(game.Id);
                Debug.WriteLine(game.GameTitle);
                Debug.WriteLine(game.Description);
                Debug.WriteLine(game.Developer);
                Debug.WriteLine(game.Publisher);
                Debug.WriteLine(game.FTPFolderPath);
                Debug.WriteLine(game.FileName);
                Debug.WriteLine(game.IconPath);
                Debug.WriteLine(game.ThumbnailPath);
                Debug.WriteLine(game.CurrentFtpPath);
                Debug.WriteLine(game.InsttallationPath);
                Debug.WriteLine("------------------");
            }
        }
    }
}
