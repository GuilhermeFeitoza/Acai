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
    public partial class FrmCargo :Modelo.FrmCadastro
        {
        public FrmCargo()
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

            BLL.Cargo c = new BLL.Cargo();
            c.Descricao = txtNomeCargo.Text;
            c.IncluirComParametro();
            MessageBox.Show("Cargo cadastrado!!!");
        }
        public void AlterarCargo(object o , EventArgs e)
        {

            if (VerificarDigitacao() == false)
            {
                return;
            }



            BLL.Cargo c = new BLL.Cargo();
            c.Descricao = txtNomeCargo.Text;
            c.CodigoCargo = Codigo;
            c.AlterarComParametro();
            MessageBox.Show("Cargo alterado!!!");



        }

        private bool VerificarDigitacao()
        {
            bool Situacao = true;

            if (txtNomeCargo.Text.Trim().Length == 0)
            {
                erro.SetError(txtNomeCargo, "Digite um nome");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtNomeCargo, "");

            }

          
           

            return Situacao;
        }



    }
}
