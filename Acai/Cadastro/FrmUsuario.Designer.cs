namespace Acai.Cadastro
{
    partial class FrmUsuario
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cbNiv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(285, 39);
            this.lblTitulo.Text = "Cadastro de usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(160, 101);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(242, 27);
            this.txtUsuario.TabIndex = 17;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(160, 145);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(185, 27);
            this.txtSenha.TabIndex = 16;
            // 
            // cbNiv
            // 
            this.cbNiv.FormattingEnabled = true;
            this.cbNiv.Location = new System.Drawing.Point(160, 193);
            this.cbNiv.Name = "cbNiv";
            this.cbNiv.Size = new System.Drawing.Size(185, 27);
            this.cbNiv.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nivel de acesso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome de usuário:";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.cbNiv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.Controls.SetChildIndex(this.bunifuFlatButton1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnCadastrar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton1, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbNiv, 0);
            this.Controls.SetChildIndex(this.txtSenha, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.ComboBox cbNiv;
    }
}