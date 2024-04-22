﻿using LauncherBackend.Database;
using LauncherBackend.Repository;
using LauncherBackend.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------------------
//              Launcher - BackendMain
//              Márton Bán (C) 2024
//  
//  This is the entry point of the backend. In this
//  approch some of our data is not go throw all of
//  the layers or skipping some of it. The main reason
//  for this, is becasue there are data's where we
//  doesn't need to do anything, for example GameDTO. 
//---------------------------------------------------

namespace LauncherBackend
{
    public class BackendMain {
        static void Main(string[] args) {
            DownloadManager downloadManager = new DownloadManager();
            downloadManager.ConnectToServer("C:/Server/FTP");
            downloadManager.IstallApplication("/Apps", "/BagComposer.zip", "C:/Server/Test", "BagComposer");
            downloadManager.IstallApplication("/Games", "/Classy_Clash_v1.0.0.zip", "C:/Server/Test", "ClassyClash");
        }
    }
}
