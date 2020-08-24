namespace Acai.Cadastro
{
    partial class FrmProduto
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
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataVenc = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataFab = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDataEnt = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumerico = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumerico)).BeginInit();
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
            this.lblTitulo.Location = new System.Drawing.Point(13, 20);
            this.lblTitulo.Size = new System.Drawing.Size(297, 39);
            this.lblTitulo.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do produto :";
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(157, 105);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(542, 27);
            this.txtProd.TabIndex = 9;
            this.txtProd.TextChanged += new System.EventHandler(this.txtProd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor R$:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(157, 226);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(93, 27);
            this.txtValor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unidade:";
            // 
            // cbUnidade
            // 
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Location = new System.Drawing.Point(444, 157);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(52, 27);
            this.cbUnidade.TabIndex = 8;
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Items.AddRange(new object[] {
            "AÇAI",
            "ACOMPANHAMENTO",
            "FRUTA"});
            this.cbCat.Location = new System.Drawing.Point(157, 162);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(172, 27);
            this.cbCat.TabIndex = 15;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(444, 229);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(249, 27);
            this.cbFornecedor.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fornecedor:";
            // 
            // txtDataVenc
            // 
            this.txtDataVenc.Location = new System.Drawing.Point(157, 370);
            this.txtDataVenc.Mask = "00/00/0000";
            this.txtDataVenc.Name = "txtDataVenc";
            this.txtDataVenc.Size = new System.Drawing.Size(100, 27);
            this.txtDataVenc.TabIndex = 19;
            this.txtDataVenc.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "Data de vencimento:\r\n\r\n";
            // 
            // txtDataFab
            // 
            this.txtDataFab.Location = new System.Drawing.Point(444, 370);
            this.txtDataFab.Mask = "00/00/0000";
            this.txtDataFab.Name = "txtDataFab";
            this.txtDataFab.Size = new System.Drawing.Size(100, 27);
            this.txtDataFab.TabIndex = 21;
            this.txtDataFab.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 38);
            this.label9.TabIndex = 20;
            this.label9.Text = "Data de fabricação:\r\n\r\n";
            // 
            // txtDataEnt
            // 
            this.txtDataEnt.Location = new System.Drawing.Point(444, 284);
            this.txtDataEnt.Mask = "00/00/0000";
            this.txtDataEnt.Name = "txtDataEnt";
            this.txtDataEnt.Size = new System.Drawing.Size(100, 27);
            this.txtDataEnt.TabIndex = 23;
            this.txtDataEnt.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 38);
            this.label10.TabIndex = 22;
            this.label10.Text = "Data de entrada:\r\n\r\n";
            // 
            // txtNumerico
            // 
            this.txtNumerico.Location = new System.Drawing.Point(157, 295);
            this.txtNumerico.Name = "txtNumerico";
            this.txtNumerico.Size = new System.Drawing.Size(93, 27);
            this.txtNumerico.TabIndex = 24;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txtNumerico);
            this.Controls.Add(this.txtDataEnt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDataFab);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDataVenc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.cbUnidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.CarregarCombo);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbUnidade, 0);
            this.Controls.SetChildIndex(this.txtProd, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.bunifuFlatButton1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnCadastrar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton1, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton2, 0);
            this.Controls.SetChildIndex(this.cbCat, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cbFornecedor, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtDataVenc, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtDataFab, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtDataEnt, 0);
            this.Controls.SetChildIndex(this.txtNumerico, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumerico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtProd;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbUnidade;
        public System.Windows.Forms.ComboBox cbCat;
        public System.Windows.Forms.ComboBox cbFornecedor;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox txtDataVenc;
        public System.Windows.Forms.MaskedTextBox txtDataFab;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox txtDataEnt;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown txtNumerico;
    }
}