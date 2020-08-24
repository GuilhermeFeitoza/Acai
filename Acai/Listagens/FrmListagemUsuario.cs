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
    public partial class FrmListagemUsuario : Modelo.FrmModeloListagem
    {
        public FrmListagemUsuario()
        {
            InitializeComponent();
        }




        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Usuario usu = new BLL.Usuario();
                usu.CodigoUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    
                    case "Ativar": usu.Ativar(); break;
                    case "Desativar": usu.Desativar(); break;

                }
                MessageBox.Show(b.Text, "Sucesso");
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
                BLL.Usuario cat = new BLL.Usuario();
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
            Cadastro.FrmUsuario u = new Cadastro.FrmUsuario();
            u.lblTitulo.Text = "Alterar usuario";
            u.txtUsuario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            u.txtSenha.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            u.cbNiv.SelectedValue = Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value);
            u.Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            u.btnCadastrar.Click -= u.btnCadastrar_Click;
            u.btnCadastrar.Click += u.Alterar;
            u.btnCadastrar.Text = "Alterar";
            u.ShowDialog();
            CarregarDadosGrid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
