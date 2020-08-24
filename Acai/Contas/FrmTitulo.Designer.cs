namespace Acai.Cadastro
{
    partial class FrmTitulo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeTitulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconVisible = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Size = new System.Drawing.Size(265, 39);
            this.lblTitulo.Text = "Cadastro de titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do titulo:";
            // 
            // txtNomeTitulo
            // 
            this.txtNomeTitulo.Location = new System.Drawing.Point(138, 126);
            this.txtNomeTitulo.Name = "txtNomeTitulo";
            this.txtNomeTitulo.Size = new System.Drawing.Size(232, 27);
            this.txtNomeTitulo.TabIndex = 7;
            // 
            // FrmTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txtNomeTitulo);
            this.Controls.Add(this.label2);
            this.Name = "FrmTitulo";
            this.Text = "FrmTitulo";
            this.Controls.SetChildIndex(this.bunifuFlatButton1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnCadastrar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton1, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNomeTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeTitulo;
    }
}