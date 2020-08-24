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
    public partial class FrmListagemFornecedor : Modelo.FrmModeloListagem
    {
        public FrmListagemFornecedor()
        {
            InitializeComponent();
        }

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Fornecedor cat = new BLL.Fornecedor();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cadastro.FrmFornecedor f = new Cadastro.FrmFornecedor();
            f.lblTitulo.Text = "Alterar fornecedor";
            f.txtRazao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            f.txtNomeFant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            f.txtCep.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            f.txtNumero.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            f.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            f.Codigo = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            f.btnCadastrar.Click -= f.btnCadastrar_Click;
            f.btnCadastrar.Click += f.Alterar;
            f.btnCadastrar.Text = "Alterar";
            f.ShowDialog();
                 CarregarDadosGrid();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cadastro.FrmFornecedor f = new Cadastro.FrmFornecedor();
            f.lblTitulo.Text = "Consultar fornecedor";
            f.txtRazao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            f.txtNomeFant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            f.txtCep.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            f.txtNumero.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            f.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            f.ShowDialog();
        }

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Fornecedor forn = new BLL.Fornecedor();
                forn.CodigoFornecedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                  
                    case "Ativar": forn.Ativar(); break;
                    case "Desativar": forn.Desativar(); break;

                }
                String msg = "";
              
                if (b.Text == "Ativar")

                {
                    msg = "Fornecedor ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Fornecedor desativado com sucesso";
                }
                MessageBox.Show(msg, "Sucesso");
                CarregarDadosGrid();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
