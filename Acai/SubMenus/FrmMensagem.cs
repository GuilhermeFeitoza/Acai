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
    public partial class FrmMensagem : Modelo.FrmSubMenu
    {
        public FrmMensagem()
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

        public void CarregarDadosGrid(object o ,EventArgs e)
        {
            try
            {
                BLL.FaleConosco f = new BLL.FaleConosco();
                dataGridView1.DataSource = f.Listar().Tables[0];
                // textBox1.Focus();
                //a propriedade DATASOURCE do datagrid é a fonte de dados. Esta propriedade recebe (=) do objeto USU o método LISTAR usando como parametro o texto TEXT.TRIM().TOUPPER() digitado no TEXTBOX1. Esse DATASOURCE usará a tabela zero TABLES[0] do método LISTAR




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Mensagens.FrmMensagem m = new Mensagens.FrmMensagem();
            m.lblCli.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value); ;
            m.txtMsg.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value); ;
            m.lblEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value); ;
            m.lblTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value); ;
            m.ShowDialog();

        }
    }
}
