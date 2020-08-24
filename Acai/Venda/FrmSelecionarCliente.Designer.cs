namespace Acai.Venda
{
    partial class FrmSelecionarCliente
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.Text = "Selecionar Cliente";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(-4, 575);
            this.btnAlterar.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(-4, 575);
            this.btnConsultar.Visible = false;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(-4, 575);
            this.btnAtivar.Visible = false;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(-4, 575);
            this.btnDesativar.Visible = false;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Click += new System.EventHandler(this.Exibir);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelecionar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(302, 575);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(227, 84);
            this.btnSelecionar.TabIndex = 16;
            this.btnSelecionar.Text = "Selecionar Cliente";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // FrmSelecionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 671);
            this.Controls.Add(this.btnSelecionar);
            this.Name = "FrmSelecionarCliente";
            this.Text = "FrmSelecionarCliente";
            this.Load += new System.EventHandler(this.Exibir);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton1, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton2, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnAtivar, 0);
            this.Controls.SetChildIndex(this.btnDesativar, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton3, 0);
            this.Controls.SetChildIndex(this.btnSelecionar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSelecionar;
    }
}