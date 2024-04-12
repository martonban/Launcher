using LauncherWinForms.View;
using LauncherWinForms.ViewModell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWinForms {
    public partial class LoadingScreenView : Form {
        public LoadingScreenView() {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            WaitSomeTime();
        }

        private void LoadingScreen_Load(object sender, EventArgs e) {

        }

        public async void WaitSomeTime() {
            await Task.Delay(10000);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
            this.Hide();
            var hub = new MainLauncherView();
            hub.Closed += (s, args) => this.Close();
            hub.Show();
        }

    }
}




 