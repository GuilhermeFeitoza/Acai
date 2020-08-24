using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acai
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Confirmar(Object o, EventArgs e)
        {



            try
            {

                if (VerificarDigitacao() == false)
                {
                    return;
                }



                BLL.Usuario usu = new BLL.Usuario();
                usu.NomeUsuario = txtNome.Text;
                usu.SenhaUsuario = txtSenha.Text;
                if (usu.Logar() != 0)
                {

                    // MessageBox.Show("Seja bem-vindo !!!");


                    // f.NivelAcesso = usu.CodigoNivelAcesso;


                    // f.NivelAcesso = 0;
                    FrmMenu m = new FrmMenu();
                    m.lblUsuarioLogado.Text = txtNome.Text;
                    m.lblNivel.Text = Convert.ToString(usu.CodigoNivelAcesso);
                   m.CodigoUsuario = usu.CodigoUsuario;

                    /*pega o valor da classe session que é uma classe 
                    que mantem um valor armazenado durante toda a execução do programa podendo ser usado em outros forms */
                
                    m.ShowDialog();
                    Close();


                }
                else
                {
                    MessageBox.Show("Erro Usuário/Senha");
                  
                    txtNome.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


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

            if (txtSenha.Text.Trim().Length == 0)
            {
                erro.SetError(txtSenha, "Digite uma senha");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtSenha, "");

            }


            return Situacao;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

