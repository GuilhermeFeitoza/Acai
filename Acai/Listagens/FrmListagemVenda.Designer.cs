namespace Acai.Listagens
{
    partial class FrmListagemVenda
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.Text = "Listagem de venda";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(-7, 571);
            this.btnAlterar.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(-7, 571);
            this.btnConsultar.Visible = false;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(-7, 571);
            this.btnAtivar.Visible = false;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(-7, 571);
            this.btnDesativar.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 56);
            this.textBox1.OnValueChanged += new System.EventHandler(this.textBox1_OnValueChanged);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Location = new System.Drawing.Point(609, 70);
            this.bunifuImageButton3.Click += new System.EventHandler(this.Exibir);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(280, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 84);
            this.button1.TabIndex = 16;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Buscar por cliente :";
            // 
            // FrmListagemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 671);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "FrmListagemVenda";
            this.Text = "FrmListagemVenda";
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
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label2;
    }
}