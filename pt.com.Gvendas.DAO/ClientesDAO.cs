using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data;
using C__GestaoVendas.pt.com.Gvendas.CONEXAO;
using C__GestaoVendas.pt.com.Gvendas.VIEWS;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace C__GestaoVendas.pt.com.Gvendas.DAO
{
    public class ClientesDAO
    {
        private MySql.Data.MySqlClient.MySqlConnection Conexao;

        public ClientesDAO() {
            this.Conexao = new ConnectionFactory().GetConnection();
        }
        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj) { 
            try 
            {
                string sql = @"INSERT into tb_clientes(cae, Cidade, email1, email2, empresa, endereco1, endereco2, endereco3, Freguesia, IsDeleted, nif, nome, numero, Pais, pos, profissao, telefone, telemovel) values (@cae, @Cidade, @email1, @email2, @empresa, @endereco1, @endereco2, @endereco3, @Freguesia, @IsDeleted, @nif, @nome, @numero, @Pais, @pos, @profissao, @telefone, @telemovel )";
                MySqlCommand executacmd = new MySqlCommand(sql, Conexao);

                executacmd.Parameters.AddWithValue("@cae", obj.cae);
                executacmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@email1", obj.email1);
                executacmd.Parameters.AddWithValue("@email2", obj.email2);
                executacmd.Parameters.AddWithValue("@empresa", obj.empresa);
                executacmd.Parameters.AddWithValue("@endereco1", obj.endereco1);
                executacmd.Parameters.AddWithValue("@endereco2", obj.endereco2);
                executacmd.Parameters.AddWithValue("@endereco3", obj.endereco3);
                executacmd.Parameters.AddWithValue("@Freguesia", obj.Freguesia);
                executacmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);
                executacmd.Parameters.AddWithValue("@nif", obj.nif);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@Pais", obj.Pais);
                executacmd.Parameters.AddWithValue("@pos", obj.pos);
                executacmd.Parameters.AddWithValue("@profissao", obj.profissao);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@telemovel", obj.telemovel);

                Conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro no cadastro: " + ex);
                throw;
            }
        }
        #endregion
    }
}
