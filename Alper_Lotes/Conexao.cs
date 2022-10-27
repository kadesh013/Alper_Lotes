using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Alper_Lotes
{
    internal class Conexao
    {
        public static MySqlConnection Open()
        {
            MySqlConnection nConn;

            //PRIMEIRA CONEXÃO-
            //  nConn = new MySqlConnection("Server=localhost; Database=db_teste; Uid=root; Pwd=Alper@1208");
            nConn = new MySqlConnection("server=192.168.0.250;User Id=alper;password=Alper@1208;database=db_teste;Persist Security Info=True");
            try
            {
                nConn.Open();
            }
            catch
            {

            }
            return nConn;
        }


        public static MySqlConnection Close()
        {
            MySqlConnection nConn;

            //PRIMEIRA CONEXÃO
              nConn = new MySqlConnection("server=192.168.0.250;User Id=alper;password=Alper@1208;database=db_teste;Persist Security Info=True");
            // nConn = new MySqlConnection("Server=localhost; Database=db_teste; Uid=root; Pwd=Alper@1208");

            try
            {
                nConn.Close();
            }
            catch
            {

            }
            return nConn;
        }

    }
}
