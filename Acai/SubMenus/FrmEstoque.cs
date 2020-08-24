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
    public partial class FrmEstoque : Modelo.FrmSubMenu
    {
        public FrmEstoque()


        {
            InitializeComponent();
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



        }


        private void CarregarGrid()
        {
            BLL.Estoque est = new BLL.Estoque();
            dataGridView1.DataSource = est.ExibirEstoque().Tables[0];

            //a propriedade DATASOURCE do datagrid é a fonte de dados. Esta propriedade recebe (=) do objeto USU o método LISTAR usando como parametro o texto TEXT.TRIM().TOUPPER() digitado no TEXTBOX1. Esse DATASOURCE usará a tabela zero TABLES[0] do método LISTAR



        }

        private void Exibir(Object o, EventArgs e)
        {
            CarregarGrid();
           

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Cadastro.FrmEstoque f = new Cadastro.FrmEstoque();
            f.Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            f.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            f.ShowDialog();
            CarregarGrid();
        }
    }
}
