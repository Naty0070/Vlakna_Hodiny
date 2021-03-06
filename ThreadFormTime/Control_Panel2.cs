using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTime.Implementation;

namespace ThreadFormTime {
    public partial class Control_Panel2 : Form {
        public Clock c = new Clock();
        public Control_Panel2(Clock c) {
            InitializeComponent();
            this.c = c;
        }

        private void btDontShow_Click(object sender, EventArgs e) {
            c.DontShow();
        }

        private void btClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btShow_Click(object sender, EventArgs e) {
            c.Show();
        }
    }
}
