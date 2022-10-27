using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alper_Lotes
{
    public partial class Frm_Menu_Principal : Form
    {
        public Frm_Menu_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Criar_Lote f = new Frm_Criar_Lote();
            f.MdiParent = this;
            f.Show();
        }

        private void criarLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection OpenForms;
            // Verifica se existe algum formulário ja aberto
            if (Application.OpenForms.OfType<Frm_Criar_Lote>().Count() > 0)
            {
                // Verifica quais os formulários abertos
                OpenForms = Application.OpenForms;
                foreach (Form open in OpenForms)
                {
                    // Verifica se o Frm_Details esta aberto
                    if (open.Name == "Frm_Criar_Lote")
                    {
                        // Realiza a exibição do Frm_Details
                        open.Show();
                    }
                }
            }
            else
            {
                // Realiza uma nova instancia do Frm_Details
                Frm_Criar_Lote newFrm_Lote = new Frm_Criar_Lote();
                newFrm_Lote.MdiParent = this;
                newFrm_Lote.Show();
            }
            
        }

        private void visualizarLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection OpenForms;
            // Verifica se existe algum formulário ja aberto
            if (Application.OpenForms.OfType<Frm_Visualizar_Lote>().Count() > 0)
            {
                // Verifica quais os formulários abertos
                OpenForms = Application.OpenForms;
                foreach (Form open in OpenForms)
                {
                    // Verifica se o Frm_Details esta aberto
                    if (open.Name == "Frm_Visualizar_Lote")
                    {
                        // Realiza a exibição do Frm_Details
                        open.Show();
                    }
                }
            }
            else
            {
                // Realiza uma nova instancia do Frm_Details
                Frm_Visualizar_Lote newFrm_Lote = new Frm_Visualizar_Lote();
                newFrm_Lote.MdiParent = this;
                newFrm_Lote.Show();
            }
    }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Menu_Principal_Load(object sender, EventArgs e)
        {
            
        }
    }
}


