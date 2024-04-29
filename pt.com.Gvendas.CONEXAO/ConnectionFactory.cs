using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace C__GestaoVendas.pt.com.Gvendas.CONEXAO
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["GestaoVendas"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
