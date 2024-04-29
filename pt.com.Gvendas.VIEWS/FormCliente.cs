using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C__GestaoVendas.pt.com.Gvendas.DAO;

namespace C__GestaoVendas.pt.com.Gvendas.VIEWS
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.cae = txtCAE.Text;
            obj.Cidade = txtCidade.Text;
            obj.email1 = txtEmail1.Text;
            obj.email2 = txtEmail2.Text;
            obj.empresa = txtEmpresa.Text;
            obj.endereco1 = txtEndereço1.Text;
            obj.endereco2 = txtEndereço2.Text;
            obj.endereco3 = txtEndereço3.Text;
            obj.Freguesia = txtFreguesia.Text;
            obj.IsDeleted = checkBox1.Checked;
            obj.nif = txtNIF.Text;
            obj.nome = txtNome.Text;
            obj.numero =txtNumero.Text;
            obj.Pais = txtPais.Text;
            obj.pos = txtPOS.Text;
            obj.profissao = txtProfissao.Text;
            obj.telefone = txtTelefone.Text;
            obj.telemovel = txtTelemovel.Text;
            ClientesDAO dao = new ClientesDAO();
            dao.cadastrarCliente(obj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Código para apagar registo*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             /* Código para adicionar registo */
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

    public class Cliente { 
        public string cae { get; set; }
        public string Cidade { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public string empresa { get; set; }
        public string endereco1 { get; set; }
        public string endereco2 { get; set; }
        public string endereco3 { get; set; }
        public string Freguesia { get; set; }
        public int id { get; set; }
        public bool IsDeleted { get; set; }
        public string nif { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }
        public string Pais { get; set; }
        public string pos { get; set; }
        public string profissao { get; set; }
        public string telefone { get; set; }
        public string telemovel { get; set; }
    }
   
}