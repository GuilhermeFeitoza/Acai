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
    public partial class FrmMenuVenda : Modelo.FrmSubMenu
    {
        public FrmMenuVenda()
        {
            InitializeComponent();
        }

        private void FrmMenuVenda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venda.FrmVenda v = new Venda.FrmVenda();
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listagens.FrmListagemVenda v = new Listagens.FrmListagemVenda();
            v.ShowDialog();
        }
    }
}
