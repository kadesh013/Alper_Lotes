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
////using iTextSharp.text;
////using iTextSharp.text.pdf;
using System.IO;
using Org.BouncyCastle.Utilities;
using DGVPrinterHelper;
namespace Alper_Lotes
{
    public partial class Frm_Visualizar_Lote : Form
    {

        public Frm_Visualizar_Lote()
        {
            
            InitializeComponent();

          
        }
        Visualizar v = new Visualizar();
        
        public void AttDtg()
        {

          

            //Select Max(cd_lote) as 'Lote' from tb_lote;
            string sql = "select distinct cd_lote as \"Código do Lote\", cd_produto as \"Código Item\", ds_produto as \"Item\", ds_endereco as \"Endereço\",\r\n sum(qt_entrada)as \"Quantidade Item\", ds_municipio as 'Região' from tb_lote l\r\n inner join tb_produto p on cd_produto = fk_lote_produto\r\n group by cd_lote;\r\n ";
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.Open());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
           
            DataTable data = new DataTable();
            adapter.Fill(data);
            dtg_lote.DataSource = data;


        }

        public void DtgEspecifico()
        {


            //Select Max(cd_lote) as 'Lote' from tb_lote;
            // string sql = "select  cd_id as \"ID\", cd_lote as \"Código Lote\", ds_produto as \"Item\", cd_produto as \"Código Produto\", sum(qt_entrada) as \"Quantidade\", ds_municipio as 'Região' from tb_lote inner join tb_produto where cd_lote = @Lote group by cd_id;";
            //   string sql = "select  cd_id as \"ID\", cd_lote as \"Código Lote\", ds_produto as \"Item\", cd_produto as \"Código Produto\", sum(qt_entrada) as \"Quantidade\", ds_endereco as 'Endereço', ds_municipio as 'Municipio' from tb_lote \r\ninner join tb_produto on fk_lote_produto = cd_produto where cd_lote = @Lote group by cd_produto; ";
            string sql = "select cd_id as \"ID\", cd_lote as \"Código Lote\", ds_produto as \"Item\", cd_produto as \"Código Produto\", sum(qt_entrada) as \"Quantidade\", ds_endereco as \"Endereço\", ds_municipio as \"Região\" from tb_lote inner join tb_produto on fk_lote_produto = cd_produto where cd_lote = @Lote group by cd_produto; ";
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.Open());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            cmd.Parameters.Add(new MySqlParameter("@Lote", MySqlDbType.VarChar)).Value = v._Cdlote;
            DataTable data = new DataTable();
            adapter.Fill(data);
            dtg_lote.DataSource = data;


        }
        private void Frm_Visualizar_Lote_Load(object sender, EventArgs e)
        {
            AttDtg();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void Retorna()
        {
          
            if (dtg_lote.RowCount > 0)
            {
                v._Cdlote = dtg_lote[0, dtg_lote.CurrentRow.Index].Value.ToString();
           
            }

            else
              {
              
            }
        }
     
        private void btn_visualizar_lote_Click(object sender, EventArgs e)
        {

            Retorna();
            DtgEspecifico();
            btn_visualizar_lote.Enabled = false;
            btn_imprimir.Enabled = true;
        }

        private void btn_abrir_lote_Click(object sender, EventArgs e)
        {
            AttDtg();
            btn_visualizar_lote.Enabled = true;
            btn_imprimir.Enabled = false;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            

            printer.Title = "SEPARAÇÃO";

            //printer.SubTitle = "An Easy to Use DataGridView Printing Object";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "ALPER EMBALAGENS";

            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dtg_lote);
            /*



            if (dtg_lote.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";  // Filtro PDF

                save.FileName = "Relatório.pdf"; // NOME DO ARQUIVO

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Impossível realizar o processo" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dtg_lote.Columns.Count); // Conta a quantidade de colunas no datagrid

                            pTable.DefaultCell.Padding = 2; // Padding padrão por celula
                             
                            pTable.WidthPercentage = 100; // Tamanho em PX da altura

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT; // Alinhamento da calula

                            foreach (DataGridViewColumn col in dtg_lote.Columns) // Para cada coluna no data grid realiza a ação

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell); // Adicionando as células

                            }

                            foreach (DataGridViewRow viewRow in dtg_lote.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells) // Para cada celula no datagrid realizar a ação

                                {

                                    pTable.AddCell(dcell.Value.ToString()); // Populando as células 

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Exportado com sucesso!!", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Erro na exportação" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("Não encontrado", "Info");

            }

           */

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dtg_lote.Width, this.dtg_lote.Height);
            dtg_lote.DrawToBitmap(bm, new Rectangle(0, 0, 500, 500));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }



}    



