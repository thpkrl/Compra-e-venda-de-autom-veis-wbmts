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
using MySql.Data.MySqlClient;

namespace Compra_e_venda_de_automóveis_wbmts
{
    public partial class cadastrofuncionario : Form
    {
        public cadastrofuncionario()
        {
            InitializeComponent();
        }

        private void cadastrofuncionario_Load(object sender, EventArgs e)
        {
           
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable (); 
            string conexao = @"Persist Security Info = False; Server = localhost; Database = webmotors; Uid = 'root'; Pwd = 'souAlenda1911'";
            MySqlConnection mySqlConnection = new MySqlConnection (conexao);
            //mySqlConnection.ConnectionString = conexao;
            mySqlConnection.Open();
            MySqlCommand inserir = new MySqlCommand();
            inserir.CommandText = "INSERT INTO cliente VALUES (" + txtnome.Text + ",'" + txttell.Text + "','" + txtcpf.Text + "','" + txtcargo.Text + "','" + txtnasc.Text + "','" + txtend.Text + "','" + txtnmr.Text + "','" + txtcomple.Text + "','" + txtbairro.Text + "','" + txtcidade.Text + "','" + txtestado.Text + "','" + txtemail.Text + "''" + txtsenha.Text + "',);";
            inserir.Connection = mySqlConnection;
            inserir.ExecuteNonQuery();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter (inserir);
            mySqlDataAdapter.Fill(dt);
            mySqlConnection.Close();
            MessageBox.Show("Cliente Cadastrado com sucesso!!");

        }
    }
}
