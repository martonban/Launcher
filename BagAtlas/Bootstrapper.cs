using BagAtlas.ViewModels;
using Caliburn.Micro;
using System.Windows;

namespace BagAtlas {
    internal class Bootstrapper : BootstrapperBase {
        
        public Bootstrapper() {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e) {
            DisplayRootViewForAsync<MainWindowViewModel>();
        }

    }
}
