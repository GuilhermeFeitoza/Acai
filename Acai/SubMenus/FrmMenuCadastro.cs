using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acai.SubMenus
{
    public partial class FrmMenuCadastro : Form
    {
        public FrmMenuCadastro()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro.FrmCargo c = new Cadastro.FrmCargo();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro.FrmCliente c = new Cadastro.FrmCliente();
            c.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cadastro.FrmFornecedor c = new Cadastro.FrmFornecedor();
            c.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cadastro.FrmFuncionario c = new Cadastro.FrmFuncionario();
            c.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cadastro.FrmNivel c = new Cadastro.FrmNivel();
            c.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cadastro.FrmProduto c = new Cadastro.FrmProduto();
            c.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cadastro.FrmUsuario u = new Cadastro.FrmUsuario();
            u.ShowDialog();
        }

        private void FrmMenuCadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro.FrmUnidade u = new Cadastro.FrmUnidade();
            u.ShowDialog();
        }
    }
}
