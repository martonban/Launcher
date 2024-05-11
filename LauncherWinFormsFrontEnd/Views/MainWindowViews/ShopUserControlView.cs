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
        public ShopUserControlView() {
            InitializeComponent();
        }

        private void ShopUserControlView_Load(object sender, EventArgs e) {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BorderStyle = BorderStyle.None;
            List <UserControl> tiles = new List <UserControl> ();
            for (int i = 0; i < 10; i++) {
                tiles.Add(new GameTileView());
                flowLayoutPanel1.Controls.Add(tiles[i]);
            }
        }
    }
}
