using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acai.Listagens
{
    public partial class FrmListagemProduto : Modelo.FrmModeloListagem
    
    {
        public FrmListagemProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show("Deseja " + b.Text + " o produto ?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Produto prod = new BLL.Produto();
                prod.CodigoProduto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                   
                    case "Ativar": prod.Ativar(); break;
                    case "Desativar": prod.Desativar(); break;

                }
                MessageBox.Show("Sucesso em  " + b.Text + " o produto", "Sucesso");
                CarregarDadosGrid();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }



        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Produto cat = new BLL.Produto();
                dataGridView1.DataSource = cat.Listar(textBox1.Text, 1).Tables[0];
                // textBox1.Focus();
                //a propriedade DATASOURCE do datagrid é a fonte de dados. Esta propriedade recebe (=) do objeto USU o método LISTAR usando como parametro o texto TEXT.TRIM().TOUPPER() digitado no TEXTBOX1. Esse DATASOURCE usará a tabela zero TABLES[0] do método LISTAR

                if (dataGridView1.Rows.Count == 0)
                {
                    btnAlterar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnAtivar.Enabled = false;
                    btnDesativar.Enabled = false;




                }
                else
                {
                    btnAlterar.Enabled = true;
                    btnConsultar.Enabled = true;
                    btnAtivar.Enabled = true;
                    btnDesativar.Enabled = true;

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cadastro.FrmProduto p = new Cadastro.FrmProduto();
            p.lblTitulo.Text = "Consultar produto";
            p.txtProd.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            p.cbUnidade.SelectedValue = Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value);
            p.txtValor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            p.cbCat.SelectedText = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            p.cbFornecedor.SelectedValue = Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value);
            p.txtDataFab.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            p.txtDataVenc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            p.txtDataEnt.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            p.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cadastro.FrmProduto p = new Cadastro.FrmProduto();
            p.lblTitulo.Text = "Alterar Produto";
            p.Codigo=Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            p.txtProd.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            p.cbUnidade.SelectedValue = Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value);
            p.txtValor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            p.cbCat.SelectedText = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            p.cbFornecedor.SelectedValue = Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value);
            p.txtDataFab.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            p.txtDataVenc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            p.txtDataEnt.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            p.btnCadastrar.Text = "Alterar";
            p.btnCadastrar.Click -= p.btnCadastrar_Click;
            p.btnCadastrar.Click += p.Alterar;
            p.ShowDialog();
            CarregarDadosGrid();
        }
    }
}
