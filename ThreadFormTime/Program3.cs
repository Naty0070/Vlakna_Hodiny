using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTime.Implementation;
using System.Threading;

namespace ThreadFormTime {
    static class Program3 {
       private static Clock c1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            c1 = new Clock();
            Thread t = new Thread(c1.loop); t.Start();
            Application.Run(new Control_Panel2(c1));
            t.Abort();
        }
    }
}
