
namespace ThreadFormTime {
    partial class Control_Panel {
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
            this.btShow = new System.Windows.Forms.Button();
            this.btDontShow = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(30, 35);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 0;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btDontShow
            // 
            this.btDontShow.Location = new System.Drawing.Point(30, 88);
            this.btDontShow.Name = "btDontShow";
            this.btDontShow.Size = new System.Drawing.Size(75, 23);
            this.btDontShow.TabIndex = 1;
            this.btDontShow.Text = "Dont show";
            this.btDontShow.UseVisualStyleBackColor = true;
            this.btDontShow.Click += new System.EventHandler(this.btDontShow_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(30, 187);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Control_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(140, 235);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDontShow);
            this.Controls.Add(this.btShow);
            this.Name = "Control_Panel";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btDontShow;
        private System.Windows.Forms.Button btClose;
    }
}

