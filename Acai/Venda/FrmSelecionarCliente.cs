using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acai.Venda
{
    public partial class FrmSelecionarCliente : Modelo.FrmModeloListagem
    {
        public FrmSelecionarCliente()
        {
            InitializeComponent();
        }
        public int Codigo;
        public string Cliente;

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Cliente cat = new BLL.Cliente();
                dataGridView1.DataSource = cat.Listar(textBox1.Text, 1).Tables[0];
                // textBox1.Focus();
                //a propriedade DATASOURCE do datagrid é a fonte de dados. Esta propriedade recebe (=) do objeto USU o método LISTAR usando como parametro o texto TEXT.TRIM().TOUPPER() digitado no TEXTBOX1. Esse DATASOURCE usará a tabela zero TABLES[0] do método LISTAR

                if (dataGridView1.Rows.Count == 0)
                {
                    btnSelecionar.Enabled = false;
                }
                else
                {

                    btnSelecionar.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void Exibir(Object o, EventArgs e)
        {
            CarregarDadosGrid();
            if (o == textBox1)
            {
                textBox1.Text = String.Empty;
            }
            textBox1.Focus();



        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Cliente= Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);

            Venda.FrmVenda v = new FrmVenda();

            Close();
        }
    }
}
