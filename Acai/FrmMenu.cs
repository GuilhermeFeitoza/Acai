using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acai
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
           
          
        }

        public void PermissõesAcesso() {
            if (lblNivel.Text == "Vendedor")
            {
                btnCad.Visible = false;lblCad.Visible = false;
                btnListagem.Visible = false;lblListagem.Visible=false;
                btnMsg.Visible = false; lblMsg.Visible = false;
                btnConta.Visible = false; lblConta.Visible = false;
                btnEstoque.Visible = false;lblEst.Visible = false;
               

                    

            }





        }

        public int CodigoUsuario;

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void AbrirCadastro(object o, EventArgs e)
        {

            AbrirFormInPanel(new SubMenus.FrmMenuCadastro());





        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new SubMenus.FrmMensagem());

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new SubMenus.FrmMenuConta());

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new SubMenus.FrmEstoque());

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new SubMenus.FrmMenuListagem());

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new SubMenus.FrmMenuVenda());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {


        }


        private void BuscarNivelAcesso(object o, EventArgs e)
        {



            try
            {
                int CodigoNivelUsuarioLogado;

                CodigoNivelUsuarioLogado = Convert.ToInt32(lblNivel.Text);

                BLL.Nivel n = new BLL.Nivel();

                n.CodigoNivel = CodigoNivelUsuarioLogado;
                System.Data.SqlClient.SqlDataReader ddr;
                ddr = n.Consultar();
                ddr.Read();

                if (ddr.HasRows)
                {

                    lblNivel.Text = Convert.ToString(ddr["NomeNivelAcesso"]);
                    PermissõesAcesso();
                }






            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = Convert.ToString(DateTime.Now);
        }
    }
}