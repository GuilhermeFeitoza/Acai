using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acai.Venda
{
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();
        }
        //Variaveis
        public int CodigoCliente;
        public decimal totalVenda;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     


        private void txtCliente_Click(object sender, EventArgs e)
        {
            FrmSelecionarCliente c = new FrmSelecionarCliente();
            c.ShowDialog();

            txtCliente.Text = c.Cliente;
            CodigoCliente = c.Codigo;

        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            BLL.Produto p = new BLL.Produto();

            cbProduto.DataSource = p.Listar(String.Empty, (byte)1).Tables[0];
            cbProduto.DisplayMember = "NomeProduto";
            cbProduto.ValueMember = "CodigoProduto";


        }
        private void AdicionarProduto(object o, EventArgs e)
        {

            try
            {

                if (cbProduto.SelectedIndex > 0)

                {

                    Double ValorTotal;

                    BLL.Produto p = new BLL.Produto();
                    System.Data.SqlClient.SqlDataReader ddr;
                    p.CodigoProduto = Convert.ToInt16(cbProduto.SelectedValue);
                    ddr = p.Consultar();
                    String ProdutoSelecionado = "";
                    ddr.Read();
                    if (ddr.HasRows)
                    {

                        ProdutoSelecionado = Convert.ToString(ddr["NomeProduto"]);
                    }

                    if (Convert.ToInt16(txtQuantidade.Text) > 0)
                    {
                        //Mais de um produto
                        ValorTotal = Convert.ToDouble(txtUnit.Text) * Convert.ToDouble(txtQuantidade.Text);
                        dataGridView1.Rows.Add(cbProduto.SelectedValue, ProdutoSelecionado, txtQuantidade.Text, ValorTotal);
                        txtQuantidade.Clear();
                        txtUnit.Clear();
                        cbProduto.SelectedIndex = -1;
                        cbProduto.Focus();
                        dataGridView1.AutoResizeColumns();
                    }
                    else
                    {
                        //Somente um produto
                        dataGridView1.Rows.Add(cbProduto.SelectedValue, Convert.ToString(cbProduto.SelectedText), txtQuantidade.Text, txtUnit.Text);
                        txtQuantidade.Clear();
                        cbProduto.SelectedIndex = -1;
                        cbProduto.Focus();
                        dataGridView1.AutoResizeColumns();
                    }
                    Decimal total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(string.Format("{0:C}",t.Cells["ValorTot"].Value?.ToString()))))
                    {
                        total += Convert.ToDecimal(row.Cells["ValorTot"].Value);
                        lblTotal.Text = string.Format("{0:C}", total);

                      
                    }

                }
                else
                {
                    MessageBox.Show("Escolha um produto para adicionar à venda!!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }




        }
        private void PreencherQuantidade(object o, EventArgs e)
        {

            try
            {
                BLL.Produto c = new BLL.Produto();
                if (cbProduto.SelectedIndex > 0)
                {
                    System.Data.SqlClient.SqlDataReader ddr;
                    ddr = c.ListarProdComQuant(Convert.ToInt16(cbProduto.SelectedValue), (byte)BLL.FuncoesGerais.TipoStatus.Ativo);
                    if (ddr.HasRows)
                    {
                        ddr.Read();
                        txtUnit.Text = Convert.ToString(ddr["ValorProduto"]);
                        txtQuantidade.Text = "1";
                        string.Format("{0:C}", txtUnit.Text = Convert.ToString(Convert.ToInt32(txtQuantidade.Text) * Convert.ToDouble(txtUnit.Text)));

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }



        }

        private void CalcularValorVenda()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
             .Where(t => !string.IsNullOrEmpty(t.Cells["ValorTot"].Value?.ToString())))
            {
                totalVenda += Convert.ToDecimal(row.Cells["ValorTot"].Value);



            }
                                 




        }



        private void SalvarProdutos()
        {

            BLL.Venda v = new BLL.Venda();
            int CodigoUltimaVenda = v.RetornarVenda();
            int CodigoProdutoGrid = 0;
            int QuantidadeGrid = 0;
            //foreachzinho para pegar linha por linha e depois ir inserindo na tabela linha por linha
            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(t.Cells["CodProd"].Value?.ToString())))
            {

                try
                {
                    CodigoProdutoGrid = Convert.ToInt32(row.Cells["CodProd"].Value);
                    QuantidadeGrid =  Convert.ToInt32(row.Cells["QuantProd"].Value);
                    DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

                    string comando;

                    SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoVenda",SqlDbType.Int) {Value = CodigoUltimaVenda },
                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = CodigoProdutoGrid },
                   new SqlParameter("@Quantidade",SqlDbType.Int) {Value = QuantidadeGrid },
                };

                    comando = "INSERT INTO tbItem_Venda(CodigoVenda,CodigoProduto,Quantidade) Values (@CodigoVenda,@CodigoProduto,@Quantidade)";
                    c.ExecutarComandoParametro(comando, listaComParametros);


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        private void AtualizarEstoque()
        {




            BLL.Estoque est = new BLL.Estoque();
            int CodigoProdutoGrid = 0;
            int QuantidadeProdutoGrid = 0;
            //foreachzinho para pegar linha por linha e depois ir inserindo na tabela linha por linha
            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(t.Cells["CodProd"].Value?.ToString())))
            {

                try
                {
                    CodigoProdutoGrid = Convert.ToInt32(row.Cells["CodProd"].Value);
                    QuantidadeProdutoGrid = Convert.ToInt32(row.Cells["QuantProd"].Value);
                    DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

                    string comando;

                    SqlParameter[] listaComParametros = {

                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = CodigoProdutoGrid },
                    new SqlParameter("@Quantidade",SqlDbType.Int) {Value = QuantidadeProdutoGrid },

                };

                    comando = "UPDATE tbEstoque SET QuantidadeAtual=QuantidadeAtual-@Quantidade WHERE CodigoProduto=@CodigoProduto";
                    c.ExecutarComandoParametro(comando, listaComParametros);


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }



















        }

        public void FinalizarVenda(object o, EventArgs e)
        {
            try
            {
                BLL.Venda v = new BLL.Venda();
                v.CodigoCliente = CodigoCliente;

                v.DataVenda = DateTime.Today;



                foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(t => !string.IsNullOrEmpty(t.Cells["ValorTot"].Value?.ToString())))
                {
                    totalVenda += Convert.ToDecimal(row.Cells["ValorTot"].Value);



                }

                v.ValorTotal = Convert.ToDecimal(totalVenda);
                v.IncluirComParametro();
                SalvarProdutos();
                AtualizarEstoque();
                MessageBox.Show("Venda finalizada com sucesso");
              
                Close();

            }
            catch (Exception ex)

            {

                throw ex;
            }







        }

        private void lblClienteConsulta_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
