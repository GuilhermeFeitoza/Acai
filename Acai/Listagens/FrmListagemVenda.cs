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
    public partial class FrmListagemVenda : Modelo.FrmModeloListagem
    {
        public FrmListagemVenda()
        {
            InitializeComponent(); }





        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Venda forn = new BLL.Venda();
                dataGridView1.DataSource = forn.ListarVendas(String.Empty).Tables[0];
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



        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Venda.FrmVenda f = new Venda.FrmVenda();
            f.btnFechar.Visible = false;
            f.Text = "Consultando Venda";

           
            f.label1.Visible = true;
            f.txtCliente.Visible = false;
            f.pictureBox1.Visible = false;
            f.pictureBox2.Visible = false;
            f.label2.Visible = false;
            f.cbProduto.Visible = false;
            f.label3.Visible = false;
            f.txtQuantidade.Visible = false;
            f.txtUnit.Visible = false;
            f.groupBox1.Visible = true;

            f.label4.Visible = false;
                 
          
            BLL.Venda v = new BLL.Venda();

            f.dataGridView1.Columns["CodProd"].Visible = false;
            f.dataGridView1.Columns["NomeProd"].Visible = false;
            f.dataGridView1.Columns["QuantProd"].Visible = false;
            f.dataGridView1.Columns["ValorTot"].Visible = false;


            f.dataGridView1.DataSource = v.ListarItensVenda(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).Tables[0];

            f.lblTotal.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            f.lblDataVenda.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            f.lblClienteConsulta.Visible = true;
            f.label5.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            f.lblClienteConsulta.Visible = true;



            f.ShowDialog();





        }

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

