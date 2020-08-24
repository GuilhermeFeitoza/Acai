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
    public partial class FrmProduto : Modelo.FrmCadastro
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void txtProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregarCombo(object o, EventArgs e)
        {

            BLL.Unidade c = new BLL.Unidade();
            cbUnidade.DataSource = c.Listar(String.Empty, (byte)1).Tables[0];
            cbUnidade.DisplayMember = "Abreviacao";
            cbUnidade.ValueMember = "CodigoUnidade";


            BLL.Fornecedor f = new BLL.Fornecedor();
            cbFornecedor.DataSource = f.Listar(String.Empty, (byte)1).Tables[0];
            cbFornecedor.DisplayMember = "NomeFantasia";
            cbFornecedor.ValueMember = "CodigoFornecedor";






        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {


            if (VerificarDigitacao() == false)
            {
                return;
            }




            BLL.Produto p = new BLL.Produto();
            p.NomeProduto = txtProd.Text;
            p.CodigoUnidade = Convert.ToInt16(cbUnidade.SelectedValue);
            p.ValorProduto = Convert.ToDecimal(txtValor.Text);
            p.Categoria = Convert.ToString(cbCat.SelectedText);
            p.CodigoFornecedor = Convert.ToInt16(cbFornecedor.SelectedValue);
            p.DataFabricacao = Convert.ToDateTime(txtDataFab.Text);
            p.DataValidade = Convert.ToDateTime(txtDataVenc.Text);
            p.DataEntrada = Convert.ToDateTime(txtDataEnt.Text);
            p.StatusProduto = 1;
            p.Quantidade = Convert.ToInt32(txtNumerico.Value);
            p.IncluirComParametro();
            p.NovoEstoque();
            MessageBox.Show("Cadastrado com sucesso");
        }

        public int Codigo;
        public void Alterar(object sender, EventArgs e)
        {



            if (VerificarDigitacao() == false)
            {
                return;
            }




            BLL.Produto p = new BLL.Produto();
            p.CodigoProduto = Codigo;
            p.NomeProduto = txtProd.Text;
            p.CodigoUnidade = Convert.ToInt16(cbUnidade.SelectedValue);
            p.ValorProduto = Convert.ToDecimal(txtValor.Text);
            p.Categoria = Convert.ToString(cbCat.SelectedText);
            p.CodigoFornecedor = Convert.ToInt16(cbFornecedor.SelectedValue);
            p.DataFabricacao = Convert.ToDateTime(txtDataFab.Text);
            p.DataValidade = Convert.ToDateTime(txtDataVenc.Text);
            p.DataEntrada = Convert.ToDateTime(txtDataEnt.Text);
            p.StatusProduto = 1;
            p.Alterar();
            MessageBox.Show("Alterado com sucesso");
            Close();
        }


        private bool VerificarDigitacao()
        {
            bool Situacao = true;

            if (txtProd.Text.Trim().Length == 0)
            {
                erro.SetError(txtProd, "Digite um nome");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtProd, "");

            }

            if (txtDataFab.Text.Trim().Length == 0)
            {
                erro.SetError(txtDataFab, "Digite uma CPF");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtDataFab, "");

            }

            if (txtDataVenc.Text.Trim().Length == 0)
            {
                erro.SetError(txtDataVenc, "Digite um Email");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtDataVenc, "");

            }


            if (txtDataEnt.Text.Trim().Length == 0)
            {
                erro.SetError(txtDataEnt, "Digite um telefone");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtDataEnt, "");

            }


            return Situacao;
        }

    }
}
