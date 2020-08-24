namespace Acai.Listagens
{
    partial class FrmListagemCargo
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.Text = "Listagem de cargo";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(155, 571);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Visible = false;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(349, 571);
            this.btnAtivar.Click += new System.EventHandler(this.Fixar);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(541, 571);
            this.btnDesativar.Click += new System.EventHandler(this.Fixar);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ClientSizeChanged += new System.EventHandler(this.bunifuImageButton3_ClientSizeChanged);
            this.bunifuImageButton3.Click += new System.EventHandler(this.Exibir);
            // 
            // FrmListagemCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 671);
            this.Name = "FrmListagemCargo";
            this.Text = "FrmListagemCargo";
            this.Load += new System.EventHandler(this.Exibir);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}