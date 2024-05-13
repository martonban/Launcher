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
    public partial class AppTileView : UserControl {

        private App app;

        public AppTileView(App instance) {
            InitializeComponent();
            app = instance;
        }

        private void AppTileView_Load(object sender, EventArgs e) {
            this.BackgroundImage = Image.FromFile(app.CurrentFTPPath + app.CoverPath);
        }

        private void button1_Click(object sender, EventArgs e) {
            InstallAppView installAppView = new InstallAppView(app);
            installAppView.Show();
        }
    }
}
