using LauncherBackend.Controller;
using LauncherWinFormsFrontEnd.BackendConnector;
using LauncherWinFormsFrontEnd.Models;
using LauncherWinFormsFrontEnd.ModelViews;
using LauncherWinFormsFrontEnd.Views.MainWindowViews;
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

        public static Backend backend = new Backend();

        public ShopUserControlView shopUserControl;
        public LibaryUserControlView libaryUserControl;
        public AppsUserControlView appsUserControl;
        public ProjectUserControlView projectUserControl;
        public GameUserControlView gameUserControlView;

        public MainWindowView() {
            InitializeComponent();
        }

        private void MainWindowView_Load(object sender, EventArgs e) {
            shopUserControl = new ShopUserControlView();
            libaryUserControl = new LibaryUserControlView();
            appsUserControl = new AppsUserControlView();
            projectUserControl = new ProjectUserControlView();
        }



        public static void UserControlContextSwich(UserControl userControl) {
            userControl.Dock = DockStyle.Right;
            userControl.Show();
            control.Add(userControl);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            UserControlContextSwich(shopUserControl);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            UserControlContextSwich(libaryUserControl);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            UserControlContextSwich(appsUserControl);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            UserControlContextSwich(projectUserControl);
        }
    }
}
