namespace Alper_Lotes
{
    partial class Frm_Menu_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lotesToolStripMenuItem
            // 
            this.lotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarLoteToolStripMenuItem,
            this.visualizarLoteToolStripMenuItem});
            this.lotesToolStripMenuItem.Name = "lotesToolStripMenuItem";
            this.lotesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lotesToolStripMenuItem.Text = "Lotes";
            // 
            // criarLoteToolStripMenuItem
            // 
            this.criarLoteToolStripMenuItem.Name = "criarLoteToolStripMenuItem";
            this.criarLoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarLoteToolStripMenuItem.Text = "Criar Lote";
            this.criarLoteToolStripMenuItem.Click += new System.EventHandler(this.criarLoteToolStripMenuItem_Click);
            // 
            // visualizarLoteToolStripMenuItem
            // 
            this.visualizarLoteToolStripMenuItem.Name = "visualizarLoteToolStripMenuItem";
            this.visualizarLoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarLoteToolStripMenuItem.Text = "Visualizar Lote";
            this.visualizarLoteToolStripMenuItem.Click += new System.EventHandler(this.visualizarLoteToolStripMenuItem_Click);
            // 
            // Frm_Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(693, 528);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Menu_Principal";
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Menu_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarLoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarLoteToolStripMenuItem;
    }
}

