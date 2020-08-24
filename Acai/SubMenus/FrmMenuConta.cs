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
    public partial class FrmMenuConta : Modelo.FrmSubMenu
    {
        public FrmMenuConta()
        {
            InitializeComponent();
        }

        private void FrmMenuConta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro.FrmConta f = new Cadastro.FrmConta();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro.FrmTitulo f = new Cadastro.FrmTitulo();
            f.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contas.FrmGestaoDeContas f = new Contas.FrmGestaoDeContas ();
            f.ShowDialog();
        }
    }
}
