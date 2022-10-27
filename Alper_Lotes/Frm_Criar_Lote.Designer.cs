namespace Alper_Lotes
{
    partial class Frm_Criar_Lote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Criar_Lote));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtg_lote = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_cd_lote = new System.Windows.Forms.Label();
            this.lbl_lote_antigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close_lote = new System.Windows.Forms.Button();
            this.cmb_end = new System.Windows.Forms.ComboBox();
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
            this.panel1.Size = new System.Drawing.Size(642, 126);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "CÓDIGO ITEM";
            // 
            // txt_ds
            // 
            this.txt_ds.Enabled = false;
            this.txt_ds.Location = new System.Drawing.Point(124, 162);
            this.txt_ds.Name = "txt_ds";
            this.txt_ds.Size = new System.Drawing.Size(225, 20);
            this.txt_ds.TabIndex = 12;
            this.txt_ds.TextChanged += new System.EventHandler(this.txt_ds_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(13, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "QUANTIDADE";
            // 
            // txt_qt
            // 
            this.txt_qt.Location = new System.Drawing.Point(124, 188);
            this.txt_qt.Name = "txt_qt";
            this.txt_qt.Size = new System.Drawing.Size(226, 20);
            this.txt_qt.TabIndex = 2;
            this.txt_qt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qt_KeyDown);
            this.txt_qt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(13, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "MUNICÍPIO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 136);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtg_lote);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 255);
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
            this.dtg_lote.Size = new System.Drawing.Size(642, 255);
            this.dtg_lote.TabIndex = 0;
            this.dtg_lote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "DESCRIÇÃO";
            // 
            // lbl_cd_lote
            // 
            this.lbl_cd_lote.AutoSize = true;
            this.lbl_cd_lote.BackColor = System.Drawing.Color.Black;
            this.lbl_cd_lote.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cd_lote.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cd_lote.Location = new System.Drawing.Point(370, 257);
            this.lbl_cd_lote.Name = "lbl_cd_lote";
            this.lbl_cd_lote.Size = new System.Drawing.Size(0, 16);
            this.lbl_cd_lote.TabIndex = 20;
            // 
            // lbl_lote_antigo
            // 
            this.lbl_lote_antigo.AutoSize = true;
            this.lbl_lote_antigo.ForeColor = System.Drawing.Color.Gold;
            this.lbl_lote_antigo.Location = new System.Drawing.Point(157, 258);
            this.lbl_lote_antigo.Name = "lbl_lote_antigo";
            this.lbl_lote_antigo.Size = new System.Drawing.Size(0, 13);
            this.lbl_lote_antigo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "CÓDIGO ULTIMO LOTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(213, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "CÓDIGO LOTE ATUAL";
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Black;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.ForeColor = System.Drawing.Color.Gold;
            this.btn_del.Location = new System.Drawing.Point(504, 138);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(99, 23);
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "Excluir";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.Gold;
            this.btn_add.Location = new System.Drawing.Point(386, 138);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_add_KeyDown);
            this.btn_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            // 
            // btn_close_lote
            // 
            this.btn_close_lote.BackColor = System.Drawing.Color.Black;
            this.btn_close_lote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close_lote.ForeColor = System.Drawing.Color.Gold;
            this.btn_close_lote.Location = new System.Drawing.Point(386, 171);
            this.btn_close_lote.Name = "btn_close_lote";
            this.btn_close_lote.Size = new System.Drawing.Size(235, 23);
            this.btn_close_lote.TabIndex = 5;
            this.btn_close_lote.Text = "Fechar Lote";
            this.btn_close_lote.UseVisualStyleBackColor = false;
            this.btn_close_lote.Click += new System.EventHandler(this.btn_close_lote_Click);
            // 
            // cmb_end
            // 
            this.cmb_end.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_end.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_end.FormattingEnabled = true;
            this.cmb_end.Items.AddRange(new object[] {
            "SANTOS",
            "SÃO VICENTE",
            "CUBATÃO",
            "LITORAL NORTE",
            "LITORAL SUL",
            "VALE DO RIBEIRA",
            "VALE DO PARAIBA",
            "SÃO PAULO"});
            this.cmb_end.Location = new System.Drawing.Point(124, 215);
            this.cmb_end.Name = "cmb_end";
            this.cmb_end.Size = new System.Drawing.Size(224, 21);
            this.cmb_end.TabIndex = 3;
            // 
            // Frm_Criar_Lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(642, 543);
            this.Controls.Add(this.cmb_end);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_lote_antigo);
            this.Controls.Add(this.lbl_cd_lote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_close_lote);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_qt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Criar_Lote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criar Lote";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Criar_Lote_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Criar_Lote_KeyPress);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtg_lote;
        private System.Windows.Forms.Label lbl_cd_lote;
        private System.Windows.Forms.Label lbl_lote_antigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close_lote;
        private System.Windows.Forms.ComboBox cmb_end;
    }
}