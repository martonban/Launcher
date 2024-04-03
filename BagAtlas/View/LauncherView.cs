using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BagAtlasWinForms.View;

namespace BagAtlas {
    public partial class LauncherView : Form {
        public LauncherView() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var launcher = new BagAtlasWinForms.View.BagAtlasMainView();
            launcher.Closed += (s, args) => this.Close();
            launcher.Show();

        }
    }
}
