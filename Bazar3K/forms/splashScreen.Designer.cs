
namespace Bazar3K
{
    partial class splashScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.singIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowHide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginHelp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "BAZAR3K";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // singIn
            // 
            this.singIn.BackColor = System.Drawing.Color.White;
            this.singIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.singIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singIn.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singIn.ForeColor = System.Drawing.Color.Black;
            this.singIn.Location = new System.Drawing.Point(108, 373);
            this.singIn.Name = "singIn";
            this.singIn.Size = new System.Drawing.Size(169, 38);
            this.singIn.TabIndex = 3;
            this.singIn.Text = "Entrar";
            this.singIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.singIn.UseVisualStyleBackColor = false;
            this.singIn.Click += new System.EventHandler(this.singIn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(391, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 452);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 77);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bem-vindo ao Sistema do \r\nBazar 3K!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 271);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(77, 278);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(237, 32);
            this.passwordBox.TabIndex = 2;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.emailBox.Location = new System.Drawing.Point(77, 196);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(237, 32);
            this.emailBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(162, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(158, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Senha:";
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackColor = System.Drawing.Color.White;
            this.btnShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHide.Image = global::Bazar3K.Properties.Resources.eyeHide;
            this.btnShowHide.Location = new System.Drawing.Point(284, 283);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(25, 23);
            this.btnShowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowHide.TabIndex = 9;
            this.btnShowHide.TabStop = false;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loginHelp
            // 
            this.loginHelp.AutoSize = true;
            this.loginHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginHelp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHelp.ForeColor = System.Drawing.Color.White;
            this.loginHelp.Location = new System.Drawing.Point(158, 313);
            this.loginHelp.Name = "loginHelp";
            this.loginHelp.Size = new System.Drawing.Size(156, 20);
            this.loginHelp.TabIndex = 10;
            this.loginHelp.Text = "Problemas com o login?";
            this.loginHelp.Click += new System.EventHandler(this.loginHelp_Click);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(27)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginHelp);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.singIn);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bazar3K - Iniciar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button singIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnShowHide;
        private System.Windows.Forms.Label loginHelp;
    }
}

