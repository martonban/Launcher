using LauncherBackend.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherBackend.Global {

    public delegate void ErrorDel(Exception exp);

    public enum ErrorTypes { 
        FATAL,
        EXISTENCE,
        WARNING,
        INPUT
    }

    public static class SignalSystem {

        public static event EventHandler ErrorThrowned;

        private static Exception currentError = null;
        private static ErrorTypes type;

        public static void ErrorHappend(Exception exp, ErrorDel del) {
            del(exp);
            Debug.WriteLine(exp.Message);
        }
        
        public static void ErrorFatal(Exception exp) {
            SetError(exp);
            type = ErrorTypes.FATAL;
        }

        public static void ErrorExistence(Exception exp) {
            SetError(exp);
            type = ErrorTypes.EXISTENCE;
        }

        public static void ErrorWarning(Exception exp) {
            SetError(exp);
            type = ErrorTypes.WARNING;
        }

        public static void ErrorInput(Exception exp) {
            SetError(exp);
            type = ErrorTypes.INPUT;
        }


        //----------------------------------------------
        //              GETTERS/SETTERS
        //----------------------------------------------
        public static Exception GetError() { 
            return currentError;
        }
        
        public static void SetError(Exception exp) { 
            currentError = exp;
        }
    }
}
