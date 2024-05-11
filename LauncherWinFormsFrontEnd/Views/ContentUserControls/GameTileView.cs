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

namespace LauncherWinFormsFrontEnd.Views.ContentUserControls {
    public partial class GameTileView : UserControl {

        private Game game;

        public GameTileView(Game game) {
            InitializeComponent();
            this.game = game;
        }

        private void GameTileView_Load(object sender, EventArgs e) {
            logo.Image = Image.FromFile(game.CurrentFtpPath + game.IconPath);
            title.Text = game.GameTitle;
            description.Text = game.Description;
        }
    }
}
