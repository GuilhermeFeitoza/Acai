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
    public partial class FrmCliente : Modelo.FrmCadastro
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        public int Codigo;
   

        public void btnCadastrar_Click(object sender, EventArgs e)
        {



            if (VerificarDigitacao() == false)
            {
                return;
            }



            BLL.Cliente c = new BLL.Cliente();
            c.NomeCliente = txtNome.Text;
            c.TelefoneCliente = txtTel.Text;
            c.EmailCliente = txtEmail.Text;
            c.StatusCliente = 1;
            c.CpfCliente = txtCPF.Text;
            c.IncluirComParametro();
            MessageBox.Show("Cadastrado com sucesso");
            Close();
        }
        public void Alterar(object o , EventArgs e)
        {

            if (VerificarDigitacao() == false)
            {
                return;
            }


            BLL.Cliente c = new BLL.Cliente();
            c.NomeCliente = txtNome.Text;
            c.TelefoneCliente = txtTel.Text;
            c.EmailCliente = txtEmail.Text;
            c.StatusCliente = 1;
            c.CpfCliente = txtCPF.Text;
            c.CodigoCliente = Codigo;
            c.AlterarComParametro();

            MessageBox.Show("alterado com sucesso");
            Close();


        }


        private bool VerificarDigitacao()
        {
            bool Situacao = true;

            if (txtNome.Text.Trim().Length == 0)
            {
                erro.SetError(txtNome, "Digite um nome");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtNome, "");

            }

            if (txtCPF.Text.Trim().Length == 0)
            {
                erro.SetError(txtCPF, "Digite uma CPF");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtCPF, "");

                }

            if(txtEmail.Text.Trim().Length == 0)
            {
                erro.SetError(txtEmail, "Digite um Email");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtEmail, "");

            }


            if (txtTel.Text.Trim().Length == 0)
            {
                erro.SetError(txtTel, "Digite um telefone");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtTel, "");

            }


            return Situacao;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
          

            if (!BLL.FuncoesGerais.IsCpf(txtCPF.Text))
            {
                MessageBox.Show("CPF invalido");
                txtCPF.Clear();
                txtCPF.Focus();

            }
        }
        private void VerificarCpfCadastrado()
        {
            DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

            int cpfCadastrado = 0;
            cpfCadastrado = c.RetornarExecuteScalar("SELECT COUNT(CodigoCliente)FROM tbCliente where Cpf ='" + txtCPF.Text + "'");

            if (cpfCadastrado > 0)
            {
                MessageBox.Show("Cpf já cadastrado no sistema ");
                txtCPF.Clear();
                txtCPF.Focus();
                return;
            }



        }
        private void ChecarEmail(object o, EventArgs e)
        {


            if (!BLL.FuncoesGerais.ValidarEmailRegEx(txtEmail.Text))
            {
                MessageBox.Show("Email Invalido!!!");
                txtEmail.Clear();
                txtEmail.Focus();
            }








        }
    }
}
