namespace Alper_Lotes
{
    partial class Frm_Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Loading));
            this.pgr_loading = new System.Windows.Forms.ProgressBar();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgr_loading
            // 
            this.pgr_loading.ForeColor = System.Drawing.SystemColors.Info;
            this.pgr_loading.Location = new System.Drawing.Point(12, 255);
            this.pgr_loading.Name = "pgr_loading";
            this.pgr_loading.Size = new System.Drawing.Size(776, 53);
            this.pgr_loading.TabIndex = 0;
            // 
            // timer_loading
            // 
            this.timer_loading.Interval = 1000;
            this.timer_loading.Tick += new System.EventHandler(this.timer_loading_Tick);
            // 
            // Frm_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.pgr_loading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Loading_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgr_loading;
        private System.Windows.Forms.Timer timer_loading;
    }
}