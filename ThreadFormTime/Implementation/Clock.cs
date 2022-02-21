using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ThreadFormTime.Implementation {
    public class Clock {
        bool show;

        public bool Show1 { get => show; set => show = value; }

        public Clock() {
            this.Show1 = true;
        }

        public void Show() {
            Console.WriteLine("Clock's are on");
            Show1 = true;
        }

        public void DontShow() {
            Console.WriteLine("Clock's are off");
            Show1 = false;
        }
        public void loop() {
            while ( true) {

                if (Show1 == true) {
                    Console.WriteLine(DateTime.Now.ToLongTimeString());
                    Thread.Sleep(1000);
                }

            }


        }
    }
}
