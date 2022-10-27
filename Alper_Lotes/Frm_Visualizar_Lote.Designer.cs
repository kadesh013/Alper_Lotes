namespace Alper_Lotes
{
    partial class Frm_Visualizar_Lote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Visualizar_Lote));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtg_lote = new System.Windows.Forms.DataGridView();
            this.btn_abrir_lote = new System.Windows.Forms.Button();
            this.btn_visualizar_lote = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lote)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 126);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtg_lote);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 263);
            this.panel2.TabIndex = 13;
            // 
            // dtg_lote
            // 
            this.dtg_lote.AllowUserToAddRows = false;
            this.dtg_lote.AllowUserToDeleteRows = false;
            this.dtg_lote.AllowUserToOrderColumns = true;
            this.dtg_lote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_lote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_lote.Location = new System.Drawing.Point(0, 0);
            this.dtg_lote.Name = "dtg_lote";
            this.dtg_lote.ReadOnly = true;
            this.dtg_lote.Size = new System.Drawing.Size(610, 263);
            this.dtg_lote.TabIndex = 0;
            // 
            // btn_abrir_lote
            // 
            this.btn_abrir_lote.BackColor = System.Drawing.Color.Black;
            this.btn_abrir_lote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir_lote.ForeColor = System.Drawing.Color.Gold;
            this.btn_abrir_lote.Location = new System.Drawing.Point(12, 132);
            this.btn_abrir_lote.Name = "btn_abrir_lote";
            this.btn_abrir_lote.Size = new System.Drawing.Size(133, 38);
            this.btn_abrir_lote.TabIndex = 15;
            this.btn_abrir_lote.Text = "Todos os Lotes";
            this.btn_abrir_lote.UseVisualStyleBackColor = false;
            this.btn_abrir_lote.Click += new System.EventHandler(this.btn_abrir_lote_Click);
            // 
            // btn_visualizar_lote
            // 
            this.btn_visualizar_lote.BackColor = System.Drawing.Color.Black;
            this.btn_visualizar_lote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizar_lote.ForeColor = System.Drawing.Color.Gold;
            this.btn_visualizar_lote.Location = new System.Drawing.Point(428, 132);
            this.btn_visualizar_lote.Name = "btn_visualizar_lote";
            this.btn_visualizar_lote.Size = new System.Drawing.Size(133, 38);
            this.btn_visualizar_lote.TabIndex = 16;
            this.btn_visualizar_lote.Text = "Lote Selecionado";
            this.btn_visualizar_lote.UseVisualStyleBackColor = false;
            this.btn_visualizar_lote.Click += new System.EventHandler(this.btn_visualizar_lote_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.Black;
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.ForeColor = System.Drawing.Color.Gold;
            this.btn_imprimir.Location = new System.Drawing.Point(235, 132);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(133, 38);
            this.btn_imprimir.TabIndex = 17;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Frm_Visualizar_Lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(610, 521);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_visualizar_lote);
            this.Controls.Add(this.btn_abrir_lote);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Visualizar_Lote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizar Lote";
            this.Load += new System.EventHandler(this.Frm_Visualizar_Lote_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtg_lote;
        private System.Windows.Forms.Button btn_abrir_lote;
        private System.Windows.Forms.Button btn_visualizar_lote;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}