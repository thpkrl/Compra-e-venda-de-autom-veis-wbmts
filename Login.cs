using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Compra_e_venda_de_automóveis_wbmts
{
    public partial class Login : Form
    {
        MySqlConnection Conexao;
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=db_agenda";

                //criar conexao com mysql
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO contato (usuario,senha) " +
                    "VALUES " +
                    "('" + txtusuario.Text + "', '" + txtsenha.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Tudo certo!");
                //executar comando insert

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click_1(object sender, EventArgs e)
        {
            String User = "etec";
            String Password = "etec";

            if (txtusuario.Text == User & txtsenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado!");
                Login Frmmain = new Login();
                Frmmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Senha incorretos");
            }
        }
    }
}
