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
    public partial class FrmUsuario : Modelo.FrmCadastro
    {
        public FrmUsuario()
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


            BLL.Usuario u = new BLL.Usuario();
            u.CodigoNivelAcesso = Convert.ToInt16(cbNiv.SelectedValue);
            u.NomeUsuario = txtUsuario.Text;
            u.SenhaUsuario = txtSenha.Text;
            u.StatusUsuario = 1;
            u.IncluirComParametro();
            MessageBox.Show("Cadastrado com sucesso!!");
        }
        public void Alterar(object o , EventArgs e) {



            if (VerificarDigitacao() == false)
            {
                return;
            }

            BLL.Usuario u = new BLL.Usuario();
            u.CodigoNivelAcesso = Convert.ToInt16(cbNiv.SelectedValue);
            u.NomeUsuario = txtUsuario.Text;
            u.SenhaUsuario = txtSenha.Text;
            u.StatusUsuario = 1;
            u.CodigoUsuario = Codigo;
            u.AlterarComParametro();
            MessageBox.Show("alterado com sucesso!!");
            Close();


        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {

            BLL.Nivel c = new BLL.Nivel();

            cbNiv.DataSource = c.Listar(String.Empty, (byte)1).Tables[0];
            cbNiv.DisplayMember = "NomeNivelAcesso";
            cbNiv.ValueMember = "CodigoNivel";

        }


        private bool VerificarDigitacao()
        {
            bool Situacao = true;

            if (txtUsuario.Text.Trim().Length == 0)
            {
                erro.SetError(txtUsuario, "Digite um nome");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtUsuario, "");

            }

            if (txtSenha.Text.Trim().Length == 0)
            {
                erro.SetError(txtSenha, "Digite uma CPF");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtSenha, "");

            }

          


            return Situacao;
        }





    }
}
