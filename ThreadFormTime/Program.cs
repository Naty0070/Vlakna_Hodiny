using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTime.Implementation;
using System.Threading;

namespace ThreadFormTime {
    static class Program {
       private static Clock c1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            c1 = new Clock();
            Application.Run(new Control_Panel());
            c1.loop();


        }
    }
}
