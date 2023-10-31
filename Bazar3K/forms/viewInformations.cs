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
    public partial class viewInformations : Form
    {
        public viewInformations()
        {
            InitializeComponent();
        }

        private void viewInformations_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost; database=db_bazar3k; uid=root; pwd=etec";
            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            mySqlConnection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from TB_FUNCIONARIO", mySqlConnection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dvgFunc.DataSource = dt;
        }

        private void CarregarDadosBanco()
        {
            string connection = "server=localhost; database=db_bazar3k; uid=root; pwd=etec";
            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            mySqlConnection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from TB_FUNCIONARIO", mySqlConnection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dvgFunc.DataSource = dt;
        }

        private void dvgFunc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codBox.Text = dvgFunc.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameBox.Text = dvgFunc.Rows[e.RowIndex].Cells[1].Value.ToString();
            cpfBox.Text = dvgFunc.Rows[e.RowIndex].Cells[2].Value.ToString();
            panelInputs.Visible = true;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; database=DB_BAZAR3K; uid=root; pwd=etec";
            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            mySqlConnection.Open();
            MySqlCommand comando = new MySqlCommand("update TB_FUNCIONARIO set nome='" + nameBox.Text + "', cpf='" + cpfBox.Text + "' where id=" + codBox.Text, mySqlConnection);
            comando.ExecuteNonQuery();

            CarregarDadosBanco();

            MessageBox.Show("Alteração realizada!");

            panelInputs.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir este funcionario?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                string connection = "server=localhost; database=DB_BAZAR3K; uid=root; pwd=etec";
                MySqlConnection mySqlConnection = new MySqlConnection(connection);
                mySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand("delete from TB_FUNCIONARIO where id=" + codBox.Text, mySqlConnection);
                comando.ExecuteNonQuery();

                CarregarDadosBanco();

                MessageBox.Show("Deleção realizada!");

                panelInputs.Visible = false;
            }
        }
    }
}
