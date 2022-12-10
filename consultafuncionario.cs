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

namespace Compra_e_venda_de_automóveis_wbmts
{
    public partial class consultafuncionario : Form
    {
        public consultafuncionario()
        {
            InitializeComponent();
        }
        
        private void consultafuncionario_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string conexao = @"serve=localhoast;Database=webmotors ;UID=root;Pwd=souAlenda1911 ";
            MySqlConnection msConnection = new MySqlConnection(conexao);
            msConnection String = conexao;
            msConnection.Open();
            MySqlCommand comando = new MySqlCommand();
            msCommand.CommandText = "select * from cliente";
            msCommand.Connection = msConnection;
            MySql Data Adapter msAdapter = new MySqlDataAdapter(msCommand);
            msdAdapter.Fill(dt);

            DataGrid Consulta.Data Source = DataTable;


        }
    }
}
