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
    public partial class ShopUserControlView : UserControl {

        private List<Game> games = new List<Game>();
        private List<UserControl> tiles = new List<UserControl>();
        
        public ShopUserControlView() {
            InitializeComponent();
        }

        private void ShopUserControlView_Load(object sender, EventArgs e) {
            games = MainWindowView.backend.GetAllGames();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BorderStyle = BorderStyle.None;

            foreach (Game game in games) {
                tiles.Add(new GameTileView(game));
            }

            foreach (UserControl userControl in tiles) {
                flowLayoutPanel1.Controls.Add(userControl);
            }
        }
    }
}
