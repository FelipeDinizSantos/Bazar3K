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

            dgv_func.DataSource = dt;
        }
    }
}
