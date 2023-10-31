
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
            this.panelInputs = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFunc)).BeginInit();
            this.panelInputs.SuspendLayout();
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
            this.dvgFunc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgFunc_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Funcionario";
            // 
            // codBox
            // 
            this.codBox.Enabled = false;
            this.codBox.Location = new System.Drawing.Point(139, 4);
            this.codBox.Name = "codBox";
            this.codBox.Size = new System.Drawing.Size(125, 20);
            this.codBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(139, 43);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(125, 20);
            this.nameBox.TabIndex = 3;
            // 
            // cpfBox
            // 
            this.cpfBox.Location = new System.Drawing.Point(139, 82);
            this.cpfBox.Name = "cpfBox";
            this.cpfBox.Size = new System.Drawing.Size(125, 20);
            this.cpfBox.TabIndex = 4;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(17, 142);
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
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.btnDelete);
            this.panelInputs.Controls.Add(this.cpfBox);
            this.panelInputs.Controls.Add(this.label3);
            this.panelInputs.Controls.Add(this.label1);
            this.panelInputs.Controls.Add(this.label2);
            this.panelInputs.Controls.Add(this.codBox);
            this.panelInputs.Controls.Add(this.submit);
            this.panelInputs.Controls.Add(this.nameBox);
            this.panelInputs.Location = new System.Drawing.Point(12, 226);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(296, 178);
            this.panelInputs.TabIndex = 8;
            this.panelInputs.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(107, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // viewInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.dvgFunc);
            this.Name = "viewInformations";
            this.Text = "viewInformations";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.viewInformations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFunc)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Button btnDelete;
    }
}