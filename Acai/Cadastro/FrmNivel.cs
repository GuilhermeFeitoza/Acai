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
    public partial class FrmNivel : Modelo.FrmCadastro
    {
        public FrmNivel()
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

            BLL.Nivel n = new BLL.Nivel();
            n.NomeNivelAcesso = txtNomeNivel.Text;
            n.IncluirComParametro();
            MessageBox.Show("Cadastrado com sucesso");
        }
        public void Alterar(object o, EventArgs e) {


            if (VerificarDigitacao() == false)
            {
                return;
            }


            BLL.Nivel n = new BLL.Nivel();
            n.CodigoNivel = Codigo;
            n.NomeNivelAcesso = txtNomeNivel.Text;
            n.AlterarComParametro();
            MessageBox.Show("Alterado com sucesso");
                Close();








        }






        private bool VerificarDigitacao()
        {
            bool Situacao = true;

            if (txtNomeNivel.Text.Trim().Length == 0)
            {
                erro.SetError(txtNomeNivel, "Digite um nome");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtNomeNivel, "");

            }

            

            return Situacao;
        }
    }
}
