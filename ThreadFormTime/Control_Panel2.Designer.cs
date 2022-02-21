
namespace ThreadFormTime {
    partial class Control_Panel2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Panel2));
            this.btShow = new System.Windows.Forms.Button();
            this.btDontShow = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btShow
            // 
            resources.ApplyResources(this.btShow, "btShow");
            this.btShow.Name = "btShow";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btDontShow
            // 
            resources.ApplyResources(this.btDontShow, "btDontShow");
            this.btDontShow.Name = "btDontShow";
            this.btDontShow.UseVisualStyleBackColor = true;
            this.btDontShow.Click += new System.EventHandler(this.btDontShow_Click);
            // 
            // btClose
            // 
            resources.ApplyResources(this.btClose, "btClose");
            this.btClose.Name = "btClose";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Control_Panel2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDontShow);
            this.Controls.Add(this.btShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Control_Panel2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btDontShow;
        private System.Windows.Forms.Button btClose;
    }
}

