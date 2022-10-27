using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Alper_Lotes
{ 

    class Lote
    {
        public static void ExcluirIdPresentenoLote(String id)
        {
            MySqlCommand delete = new MySqlCommand("delete from tb_lote where cd_id = @ID;", Conexao.Open());
            delete.Parameters.Add(new MySqlParameter("@ID", MySqlDbType.VarChar)).Value = id;

            int linhasAfetadas = 0;
            Conexao.Open();
            linhasAfetadas = delete.ExecuteNonQuery();
            Conexao.Close();
            if (linhasAfetadas != 0)
            {


            }
            else
            {

            }

        }
}

}