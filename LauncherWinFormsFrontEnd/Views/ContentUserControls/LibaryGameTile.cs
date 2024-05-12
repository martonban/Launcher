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
    public partial class LibaryGameTile : UserControl {

        private Game game;
        
        public LibaryGameTile(Game instance) {
            InitializeComponent();
            game = instance;
        }

        private void LibaryGameTile_Load(object sender, EventArgs e) {
            label1.Text = game.GameTitle;
            pictureBox1.Image = Image.FromFile(game.CurrentFtpPath + game.ThumbnailPath);
        }
    }
}
