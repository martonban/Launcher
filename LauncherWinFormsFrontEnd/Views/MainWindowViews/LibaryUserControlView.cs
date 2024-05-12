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
    public partial class LibaryUserControlView : UserControl {
        public LibaryUserControlView() {
            InitializeComponent();
        }

        private void LibaryUserControlView_Load(object sender, EventArgs e) {
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel2.BorderStyle = BorderStyle.None;
            List<Game> games = MainWindowView.backend.GetAllInstalledGame();
            List<UserControl> tiles = new List<UserControl>();

            foreach (Game game in games) {
                tiles.Add(new LibaryGameTile(game));
            }

            foreach (LibaryGameTile tile in tiles) {
                flowLayoutPanel2.Controls.Add(tile);
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) {

        }
    }
}
