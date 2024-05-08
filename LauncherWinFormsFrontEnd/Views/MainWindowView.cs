using LauncherWinFormsFrontEnd.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWinFormsFrontEnd.Views {
    public partial class MainWindowView : Form {
        public MainWindowView() {
            InitializeComponent();
        }

        private void MainWindowView_Load(object sender, EventArgs e) {
            MainWindowViewModel viewModel = new MainWindowViewModel();
        }
    }
}
