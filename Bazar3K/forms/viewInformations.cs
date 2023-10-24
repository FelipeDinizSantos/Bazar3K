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
            string connection = "server=localhost; database=DB_BAZAR3K; uid=root; pwd=etec";
            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            mySqlConnection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from TB_FUNCIONARIO", mySqlConnection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dvgFunc.DataSource = dt;
        }

        private void dgv_func_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codBox.Text = dvgFunc.Rows[e.RowIndex].Cells[0].Value.toString());
            nameBox.Text = dvgFunc.Rows[e.RowIndex].Cells[1].Value.toString());
            cpfBox.Text = dvgFunc.Rows[e.RowIndex].Cells[2].Value.toString());
        }

        private void dgv_func_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
