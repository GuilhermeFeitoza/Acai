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
    public partial class FrmMenuListagem : Modelo.FrmSubMenu
    {
        public FrmMenuListagem()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listagens.FrmListagemCargo c = new Listagens.FrmListagemCargo();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listagens.FrmListagemCliente c = new Listagens.FrmListagemCliente();
            c.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Listagens.FrmListagemFornecedor c = new Listagens.FrmListagemFornecedor();
            c.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listagens.FrmListagemFuncionario c = new Listagens.FrmListagemFuncionario();
            c.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Listagens.FrmListagemNivel c = new Listagens.FrmListagemNivel();
            c.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Listagens.FrmListagemProduto c = new Listagens.FrmListagemProduto();
            c.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Listagens.FrmListagemUsuario c = new Listagens.FrmListagemUsuario();
            c.ShowDialog();
        }

        private void FrmMenuListagem_Load(object sender, EventArgs e)
        {

        }
    }
}
