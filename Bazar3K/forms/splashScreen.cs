using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace Bazar3K
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            byte[] eyeHideBytes = ImageToByteArray(Properties.Resources.eyeHide);
            byte[] currentImageBytes = ImageToByteArray(btnShowHide.Image);

            if (StructuralComparisons.StructuralEqualityComparer.Equals(eyeHideBytes, currentImageBytes))
            {
                passwordBox.PasswordChar = '\0';
                btnShowHide.Image = Properties.Resources.eyeView;
            }
            else
            {
                passwordBox.PasswordChar = '*';
                btnShowHide.Image = Properties.Resources.eyeHide;
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png); 
                return ms.ToArray();
            }
        }

        private void singIn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(emailBox.Text) && !string.IsNullOrEmpty(passwordBox.Text))
            {
                if(emailBox.Text == "funcionario@example.com" && passwordBox.Text == "1234")
                {
                    registerOptions registerPage = new registerOptions();
                    this.Hide();
                    registerPage.Show();
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos!","ERRO");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos!","ERRO");
            }
        }

        private void loginHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contate-nos:\nbazar3Ksuporte@gmail.com", "Fale consonco!");
        }
    }
}
