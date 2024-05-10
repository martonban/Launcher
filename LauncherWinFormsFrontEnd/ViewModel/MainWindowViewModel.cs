using LauncherWinFormsFrontEnd.BackendConnector;
using LauncherWinFormsFrontEnd.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherWinFormsFrontEnd.ModelViews {
    
    public class MainWindowViewModel {
        public UserControl currentUserControl;

        public Backend backend = new Backend();



    }
}
