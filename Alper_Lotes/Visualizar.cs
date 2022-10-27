using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql;
using MySql.Data;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Alper_Lotes
{
    public class Visualizar
    {
        private string cdlote; // Campo
        private string dslote;
        private string maxlote;
        private string newlote;
        public string _Cdlote   // Propriedade
        {
            get { return cdlote; }   // get metodo
            set { cdlote = value; }  // set metodo
        }
      
        public string _Dslote
        {
            get { return dslote; }
            set { dslote = value; }
        }

 
        public string _MaxLote
        {
            get { return maxlote; }
            set { maxlote = value; }
        }

        public string _NewLote
        {
            get
            {
                return newlote;
            }
            set
            {
                newlote = value;
            }
        }


        public DataTable SelectFromTbLote()
        {
            string sql = "select cd_id as 'ID', ds_produto as 'Descrição', qt_entrada as 'Quantidade', ds_endereco as 'Endereço', fk_lote_produto as 'Código Produto' from tb_lote inner join tb_produto on cd_produto = fk_lote_produto where cd_lote = @CD_LOTE;";
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.Open());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            cmd.Parameters.Add(new MySqlParameter("@CD_LOTE", MySqlDbType.Int16)).Value = _Cdlote;
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public string SelectMaxLoteFromTbLote()
        {


            try
            {


                String sqlSelect = "select max(cd_lote) from tb_lote;";
                MySqlCommand comando = new MySqlCommand(sqlSelect, Conexao.Open());
                MySqlDataReader DataReader;
                DataReader = comando.ExecuteReader();
                Conexao.Open();
                while (DataReader.Read())
                {
                    _MaxLote = DataReader.GetString(0);
                }

                Conexao.Close();
                return _MaxLote;

            }
            catch
            {
                return null;
            }
        }

        public string SelectMaxLoteFromTbLoteSumOne()
        {

            try
            {

                String sqlSelect = "select max(cd_lote)+1 from tb_lote;";
                MySqlCommand comando = new MySqlCommand(sqlSelect, Conexao.Open());

                MySqlDataReader DataReader;
                DataReader = comando.ExecuteReader();
                Conexao.Open();
                while (DataReader.Read())
                {
                    _NewLote = DataReader.GetString(0);
                }
                Conexao.Close();
                return _NewLote;
            }

            catch
            {
                return null;
            }
        }

    

        public string SelectDsFromTbProduto()
        {

            try
            {


                String dado = "";

                String sqlSelect = "select ds_produto from tb_produto where cd_produto = @DS;";
                MySqlCommand comando = new MySqlCommand(sqlSelect, Conexao.Open());
                comando.Parameters.Add(new MySqlParameter("@DS", MySqlDbType.VarChar)).Value = _Dslote;
                MySqlDataReader DataReader;
                DataReader = comando.ExecuteReader();
                Conexao.Open();
                while (DataReader.Read())
                {
                    dado = DataReader.GetString(0);
                }
                MySqlDataAdapter adptAtualiza = new MySqlDataAdapter(comando);

                _Dslote = dado;
                return _Dslote;
                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
       
    }

}

