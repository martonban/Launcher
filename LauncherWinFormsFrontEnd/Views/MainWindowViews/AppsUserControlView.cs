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
    public partial class AppsUserControlView : UserControl {
        public AppsUserControlView() {
            InitializeComponent();
        }



        private void AppsUserControlView_Load(object sender, EventArgs e) {
            List<App> apps = MainWindowView.backend.GetAllApplication();
            List<UserControl> userControls = new List<UserControl>();

            foreach (App app in apps) {
                userControls.Add(new AppTileView(app));
            }

            foreach (UserControl control in userControls) {
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            AppTestView appTestView = new AppTestView();
            appTestView.Show();
        }
    }
}
