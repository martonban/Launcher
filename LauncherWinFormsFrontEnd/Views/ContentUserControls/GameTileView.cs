using LauncherWinFormsFrontEnd.Models;
using LauncherWinFormsFrontEnd.Views.MainWindowViews;

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            UserControl userControl = new GameUserControlView(game);
        }
    }
}
