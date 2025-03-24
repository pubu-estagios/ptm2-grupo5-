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
        private void OpenFormP(object formP)
        {
            if (this.panelContedor.Controls.Count > 0)
                this.panelContedor.Controls.RemoveAt(0);
            Form fh = formP as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContedor.Controls.Add(fh);
            this.panelContedor.Tag = fh;
            fh.Show();
        }
        public void backPainel()
        {
            OpenFormP(new Views.Painel_Controle(this));
        }
        private void btnTurma_Click(object sender, EventArgs e)
        {

        }

        private void maximizeMenu_Click(object sender, EventArgs e)
        {
            this.maximizeMenu.Visible = false;
            this.minizeMenu.Visible = true;
            this.panelMenuPrincipal.Size = new System.Drawing.Size(40, 457);
        }

        private void btnControlo_Click(object sender, EventArgs e)
        {
            OpenFormP(new Views.Painel_Controle(this));
            
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
    }
}
