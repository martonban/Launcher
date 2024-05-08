using LauncherBackend.Global;
using LauncherWinFormsFrontEnd.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------------------
//     LauncherWinFormsFrontEnd - SignalSystem
//          Copyright Marton Ban (C) 2024
//  In this class will handle the 
//-----------------------------------------------------

namespace LauncherWinFormsFrontEnd.BackendConnector {
    public class SignalSystemFrontend {
        private Backend backend = null;
        //private SignalSystemServiceBackend backendService;
        
        public SignalSystemFrontend(Backend backend) {
            this.backend = backend;
            //this.backendService = backend.signalSystemBackend;
        }
    }
}
