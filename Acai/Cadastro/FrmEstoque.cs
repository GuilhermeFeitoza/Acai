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
    public partial class FrmEstoque : Modelo.FrmCadastro
    {
        public int Codigo;
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.Estoque f = new BLL.Estoque();
            f.QuantidadeAtual = Convert.ToInt32(numericUpDown1.Value);
            f.CodigoProduto = Codigo;
            f.AtualizarEstoque();
            MessageBox.Show("Estoque atualizado");
            Close();
        }
    }
}
