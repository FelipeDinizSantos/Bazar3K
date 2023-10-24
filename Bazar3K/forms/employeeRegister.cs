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

namespace Bazar3K
{
    public partial class employeeRegister : Form
    {
        public employeeRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; database=db_bazar3k; uid=root; pwd=etec";
            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            mySqlConnection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("insert into TB_FUNCIONARIO(nome, cpf, tel, endereco, periodo) values ('" + nameBox.Text + "', '" + cpfBox.Text + "', '" + telBox.Text + "', '" + enderecoBox.Text + "', '" + periodoBox.Text + "')", mySqlConnection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            MessageBox.Show("Cadastro realizado com sucesso!","Sucesso");
            this.Close();
        }

        private void employeeRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
