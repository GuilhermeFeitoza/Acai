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
    public partial class FrmFornecedor : Modelo.FrmCadastro
    {
        public FrmFornecedor()
        {
            InitializeComponent();
            
        }

        public int Codigo;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {


            if (VerificarDigitacao() == false)
            {
                return;
            }




            BLL.Fornecedor f = new BLL.Fornecedor();
            f.RazaoSocial = txtRazao.Text;
            f.NomeFantasia = txtNomeFant.Text;
            f.CEP = txtCep.Text;
            f.Numero = txtNumero.Text;
            f.Complemento = txtComplemento.Text;
            f.StatusFornecedor = 1;
            f.IncluirComParametro();
            MessageBox.Show("Inserido com sucesso");
        }

        private void BuscarEndereco(Object o, EventArgs e)
        {

            BLL.CEP Correios = new BLL.CEP();
            try
            {
                if (txtCep.Text.Length == 0)
                {
                    MessageBox.Show("Por favor digite o cep");
                    return;
                }
                Correios.NumeroCep = txtCep.Text;
                System.Data.SqlClient.SqlDataReader ddr;
                ddr = Correios.ConsultarCEP();
                ddr.Read();
                if (ddr.HasRows)
                {
                    txtLogradouro.Text = Convert.ToString(ddr["Logradouro"]);
                    txtBairro.Text = Convert.ToString(ddr["Bairro"]);
                    txtCidade.Text = Convert.ToString(ddr["Cidade"]);
                    txtUf.Text = Convert.ToString(ddr["UF"]);

                }
                else
                {
                    MessageBox.Show("Cep incorreto");
                    txtCep.Clear();
                    txtCep.Focus();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        
        public void Alterar(object o ,EventArgs e)
        {


            if (VerificarDigitacao() == false)
            {
                return;
            }

            
            BLL.Fornecedor f = new BLL.Fornecedor();
            f.RazaoSocial = txtRazao.Text;
            f.NomeFantasia = txtNomeFant.Text;
            f.CEP = txtCep.Text;
            f.Numero = txtNumero.Text;
            f.Complemento = txtComplemento.Text;
            f.StatusFornecedor = 1;
            f.CodigoFornecedor = Codigo;
            f.AlterarComParametro();
            MessageBox.Show("alterado com sucesso");
            Close();


        }


        private bool VerificarDigitacao()
        {
            bool Situacao = true;

            if (txtNomeFant.Text.Trim().Length == 0)
            {
                erro.SetError(txtNomeFant, "Digite um nome");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtNomeFant, "");

            }

            if (txtRazao.Text.Trim().Length == 0)
            {
                erro.SetError(txtRazao, "Digite uma Razao");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtRazao, "");

            }



            return Situacao;
        }


    }
}
