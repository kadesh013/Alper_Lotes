using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Utilities.Collections;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace Alper_Lotes
{
    public partial class Frm_Criar_Lote : Form
    {
        public Frm_Criar_Lote()
        {
            InitializeComponent();
        }

   
       
      
       

        private void Form2_Load(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            visualizar.SelectMaxLoteFromTbLote();

            lbl_lote_antigo.Text = visualizar._MaxLote;
            visualizar.SelectMaxLoteFromTbLoteSumOne();
            lbl_cd_lote.Text = visualizar._NewLote;
         
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // vamos obter a linha da célula selecionada
            //  DataGridViewRow linhaAtual = dtg_lote.CurrentRow;

            // vamos exibir o índice da linha atual
            //int indice = linhaAtual.Index;
            // MessageBox.Show("O índice da linha atual é: " + indice);
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            Visualizar visual = new Visualizar();
            
            if (txt_ds.Text == "" || txt_qt.Text == "" || cmb_end.Text == "")
            {
                MessageBox.Show("Preencha os campos em vazio");
            }
            else
            { 
            MySqlCommand comando = new MySqlCommand("insert into tb_lote(cd_lote,qt_entrada,fk_lote_produto,ds_municipio) values(@Lote,@QT,@FK,@END);", Conexao.Open());
            comando.Parameters.Add(new MySqlParameter("@QT", MySqlDbType.VarChar)).Value = txt_qt.Text;
            comando.Parameters.Add(new MySqlParameter("@FK", MySqlDbType.VarChar)).Value = textBox1.Text;
            comando.Parameters.Add(new MySqlParameter("@Lote", MySqlDbType.VarChar)).Value = lbl_cd_lote.Text;
            comando.Parameters.Add(new MySqlParameter("@END", MySqlDbType.VarChar)).Value = cmb_end.Text;



            int linhasAfetadas = 0;
            Conexao.Open();
            try
            {
                    linhasAfetadas = comando.ExecuteNonQuery();
                    //AttDtg();
                    // lbl_cd_lote.Text = visual._Cdlote;
                    // dtg_lote.DataSource = visual.SelectFromTbLote();







                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                visual._Cdlote = lbl_cd_lote.Text; 
                dtg_lote.DataSource = visual.SelectFromTbLote();
                Conexao.Close();
            }
            /* string sql = @"
 select cd_lote as ""Código do Lote"", cd_produto as ""Código Item"", ds_produto as ""Item"", ds_obs as ""Endereço"",
  sum(qt_entrada) as ""Quantidade Item"" from tb_lote l inner join tb_produto p on cd_produto = fk_lote_produto
   group by cd_produto; ";
            
         

             */
            textBox1.Text = "";
            txt_qt.Text = "";
            txt_ds.Text = "";
            textBox1.Focus();
           
          
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
      
        }

        private void txt_ds_TextChanged(object sender, EventArgs e)
        {

        }
        public static String RetornaApelidoDt(DataGridView dtg_int)
        {
            if (dtg_int.RowCount > 0)
            {

                String nome = dtg_int[0, dtg_int.CurrentRow.Index].Value.ToString();
                return nome;
            }
            else
            {
                return null;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lote.ExcluirIdPresentenoLote(RetornaApelidoDt(dtg_lote));
            Visualizar visual = new Visualizar();
            visual.SelectFromTbLote();

        }

        private void btn_close_lote_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja fechar o lote?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {


         
                Visualizar visual = new Visualizar();
                visual.SelectFromTbLote();
                lbl_lote_antigo.Text = visual.SelectMaxLoteFromTbLote();
                lbl_cd_lote.Text = visual.SelectMaxLoteFromTbLoteSumOne();
            }
        }
        private void btn_add_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btn_add_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Frm_Criar_Lote_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Frm_Criar_Lote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btn_add.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btn_del.PerformClick();
            }
            else { }
        }

        private void txt_qt_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Visualizar visual = new Visualizar();
                visual._Dslote = textBox1.Text; 
                txt_ds.Text = visual.SelectDsFromTbProduto();
                txt_qt.Focus();
            }
        }

        private void txt_qt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }
        }
    }
}

