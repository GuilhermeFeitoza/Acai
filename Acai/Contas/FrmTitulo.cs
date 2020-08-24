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
    public partial class FrmTitulo : Modelo.FrmCadastro
    {
        public FrmTitulo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.Titulo t = new BLL.Titulo();
            t.DescricaoTitulo = txtNomeTitulo.Text;
            t.StatusTitulo = 1;
            t.IncluirComParametro();
            MessageBox.Show("Cadastrado com sucesso!!");
            
        }
    }
}
