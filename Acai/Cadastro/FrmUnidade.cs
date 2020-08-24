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
    public partial class FrmUnidade : Modelo.FrmCadastro
    {
        public FrmUnidade()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.Unidade u = new BLL.Unidade();
            u.NomeUnidade = txtNomeCargo.Text;
            u.Abreviacao = textBox1.Text;
            u.IncluirComParametro();
            MessageBox.Show("Cadastrado com sucesso");
        }
    }
}
