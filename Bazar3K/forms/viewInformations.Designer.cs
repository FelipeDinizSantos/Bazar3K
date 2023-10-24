
namespace Bazar3K
{
    partial class viewInformations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgFunc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.codBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cpfBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgFunc
            // 
            this.dvgFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFunc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgFunc.Location = new System.Drawing.Point(12, 12);
            this.dvgFunc.Name = "dvgFunc";
            this.dvgFunc.Size = new System.Drawing.Size(776, 179);
            this.dvgFunc.TabIndex = 0;
            this.dvgFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_func_CellContentClick);
            this.dvgFunc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_func_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Funcionario";
            // 
            // codBox
            // 
            this.codBox.Enabled = false;
            this.codBox.Location = new System.Drawing.Point(240, 252);
            this.codBox.Name = "codBox";
            this.codBox.Size = new System.Drawing.Size(125, 20);
            this.codBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(240, 291);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(125, 20);
            this.nameBox.TabIndex = 3;
            // 
            // cpfBox
            // 
            this.cpfBox.Location = new System.Drawing.Point(240, 330);
            this.cpfBox.Name = "cpfBox";
            this.cpfBox.Size = new System.Drawing.Size(125, 20);
            this.cpfBox.TabIndex = 4;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(118, 390);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "Alterar";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // viewInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.cpfBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.codBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgFunc);
            this.Name = "viewInformations";
            this.Text = "viewInformations";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.viewInformations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox cpfBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}