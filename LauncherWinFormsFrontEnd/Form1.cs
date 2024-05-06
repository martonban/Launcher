using LauncherWinFormsFrontEnd.BackendConnector;
using LauncherWinFormsFrontEnd.Models;
using System.Diagnostics;

namespace LauncherWinFormsFrontEnd {
    public partial class Form1 : Form {

        BackendConnector.Backend backend = new BackendConnector.Backend();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        
        }

        private void button1_Click(object sender, EventArgs e) {
            int id = Int32.Parse(textBox1.Text);
            Game game = backend.GetGameById(id);
            label1.Text = game.GameTitle.ToString();
            label2.Text = game.FTPFolderPath;
            label3.Text = game.FileName;
        }
    }
}
