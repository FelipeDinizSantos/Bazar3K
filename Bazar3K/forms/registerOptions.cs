using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bazar3K
{
    public partial class registerOptions : Form
    {
        public registerOptions()
        {
            InitializeComponent();
        }

        private void employeeIcon_Click(object sender, EventArgs e)
        {
            employeeRegister employeeRegisterPage = new employeeRegister();
            employeeRegisterPage.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            viewInformations viewInformationsPage = new viewInformations();
            viewInformationsPage.Show();
        }
    }
}
