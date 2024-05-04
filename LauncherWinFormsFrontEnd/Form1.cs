using System.Diagnostics;

namespace LauncherWinFormsFrontEnd {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            LauncherBackend.EntryPoint.Main();

            LauncherBackend.Controller.GameController gamecontroller = new LauncherBackend.Controller.GameController();
            string? data = "TEST";

            label1.Text = data;

        }
    }
}
