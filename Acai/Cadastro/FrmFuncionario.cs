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
    public partial class FrmFuncionario : Modelo.FrmCadastro
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        public int Codigo;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (VerificarDigitacao() == false)
            {
                return;
            }




            BLL.Funcionario f = new BLL.Funcionario();
            f.NomeFuncionario = txtNome.Text;
            f.CpfFuncionario = mskCPF.Text;
            f.TelefoneFuncionario = mskTelefone.Text;
            //f.CodigoCargo = Convert.ToInt16(cbCargo.SelectedValue);
            f.CodigoCargo = 1;
                
            f.StatusFuncionario = 1;
            f.IncluirComParametro();
            MessageBox.Show("Cadastrado com sucesso!!");
        }
        public void CarregarCombo(object o, EventArgs e)
        {

            BLL.Cargo c = new BLL.Cargo();

            cbCargo.DataSource = c.Listar(String.Empty, (byte)1).Tables[0];
            cbCargo.DisplayMember = "Descricao";
            cbCargo.ValueMember = "CodigoCargo";






        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void Alterar(object o, EventArgs e) {


            if (VerificarDigitacao() == false)
            {
                return;
            }



            BLL.Funcionario f = new BLL.Funcionario();
            f.NomeFuncionario = txtNome.Text;
            f.CpfFuncionario = mskCPF.Text;
            f.CodigoFuncionario = Codigo;
            f.TelefoneFuncionario = mskTelefone.Text;
            f.CodigoCargo = Convert.ToInt16(cbCargo.SelectedValue);
            f.StatusFuncionario = 1;
            f.AlterarComParametro();
            MessageBox.Show("Alterado com sucesso!!");
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

            if (mskCPF.Text.Trim().Length == 0)
            {
                erro.SetError(mskCPF, "Digite uma CPF");
                Situacao = false;
            }
            else
            {
                erro.SetError(mskCPF, "");

            }

            if (mskTelefone.Text.Trim().Length == 0)
            {
                erro.SetError(mskTelefone, "Digite um Email");
                Situacao = false;
            }
            else
            {
                erro.SetError(mskTelefone, "");

            }


        
            return Situacao;
        }


        private void txtCPF_Leave(object sender, EventArgs e)
        {


            if (!BLL.FuncoesGerais.IsCpf(mskCPF.Text))
            {
                MessageBox.Show("CPF invalido");
                mskCPF.Clear();
                mskCPF.Focus();

            }
        }
        private void VerificarCpfCadastrado()
        {
            DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

            int cpfCadastrado = 0;
            cpfCadastrado = c.RetornarExecuteScalar("SELECT COUNT(CodigoCliente)FROM tbCliente where Cpf ='" + mskCPF.Text + "'");

            if (cpfCadastrado > 0)
            {
                MessageBox.Show("Cpf já cadastrado no sistema ");
                mskCPF.Clear();
                mskCPF.Focus();
                return;
            }



        }





        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
