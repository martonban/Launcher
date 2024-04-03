using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagAtlas.Forms {
    public partial class LoadingScreen : Form {
        public LoadingScreen() {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            WaitSomeTime();
        }

        public async void WaitSomeTime() {
            await Task.Delay(10000);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
            this.Hide();
            var hub = new Hub();
            hub.Closed += (s, args) => this.Close();
            hub.Show();
        }
    }
}
