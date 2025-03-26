using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDeFacturacao
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }
        //Abrir formulario dentro de um painel 
        private void openForm(object form)
        {
            if (this.panelContedor.Controls.Count > 0)
                this.panelContedor.Controls.RemoveAt(0);
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelContedor.Controls.Add(frm);
            this.panelContedor.Tag = frm;
            frm.Show();

        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            openForm(new FormClientes());
        }

        private void maximizeMenu_Click(object sender, EventArgs e)
        {
            this.maximizeMenu.Visible = false;
            this.minizeMenu.Visible = true;
            this.panelMenuPrincipal.Size = new System.Drawing.Size(40, 457);
        }

        private void btnControlo_Click(object sender, EventArgs e)
        {
            openForm(new painelControle());
            
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minizeMenu_Click(object sender, EventArgs e)
        {
            this.minizeMenu.Visible = false;
            this.maximizeMenu.Visible = true;
            this.panelMenuPrincipal.Size = new System.Drawing.Size(165, 457);
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            openForm(new FormProdutos());
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            openForm(new FormUsuarios());
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {

        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguracoes_Click_1(object sender, EventArgs e)
        {
            FormConfigSistema fr = new FormConfigSistema();
            fr.ShowDialog();
        }
    }
}
