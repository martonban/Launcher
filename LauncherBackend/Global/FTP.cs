using LauncherBackend.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Global {
    public static class FTP {
        private static string ftpRoot = null;

        public static void Connect(string FTPURL) {
            if (!FileSystemService.IsPathExist(FTPURL)) {
                throw new FTPServerConnectionException("Connot connect to FTP Server");
            } else {
                ftpRoot = FTPURL;
            }
        }

        public static string GetRoot() {
            return ftpRoot;
        }

        public static bool IsThisFileExistInFTP(string path) {
            if (File.Exists(path)) {
                return true;
            } else {
                return false;
            }
        }
    }
}
