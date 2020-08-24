using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acai.Cadastro
{
    public partial class FrmConta : Modelo.FrmCadastro
    {
        public FrmConta()
        {
            InitializeComponent();
        }

        private void FrmConta_Load(object sender, EventArgs e)
        {


           

            BLL.Titulo c = new BLL.Titulo();

            comboBox1.DataSource = c.Listar(String.Empty, (byte)1).Tables[0];
            comboBox1.DisplayMember = "DescricaoTitulo";
            comboBox1.ValueMember = "CodigoTitulo";







    }

        private void btnCadastrar_Click(object sender, EventArgs e)

        {

            BLL.Conta c = new BLL.Conta();
            c.CodigoTitulo = Convert.ToInt32(comboBox1.SelectedValue);
            c.DataVencimento = Convert.ToDateTime(mskData.Text);
            c.ValorConta = Convert.ToDecimal(txtValor.Text);
            c.Incluir();
            MessageBox.Show("Cadastrada com sucesso!!!");

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
