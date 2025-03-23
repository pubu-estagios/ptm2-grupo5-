using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_Escolar.Telas
{
    public partial class Form1Principal : Form
    {
        private readonly Form1 _parent;
        public Form1Principal(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        private void openForm(object form)
        {
            if (this.loaderPage.Controls.Count > 0)
                this.loaderPage.Controls.RemoveAt(0);
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.loaderPage.Controls.Add(frm);
            this.loaderPage.Tag = frm;
            frm.Show();

        }
        private void maximizeMenu_Click(object sender, EventArgs e)
        {
            this.maximizeMenu.Visible = false;
            this.minizeMenu.Visible = true;
            this.menuPrincipal.Size = new System.Drawing.Size(40, 457);
        }

        private void minizeMenu_Click(object sender, EventArgs e)
        {
            this.minizeMenu.Visible = false;
            this.maximizeMenu.Visible = true;
            this.menuPrincipal.Size = new System.Drawing.Size(165, 457);

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.activeBtn.Location = new System.Drawing.Point(0, 43);
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            this.activeBtn.Location = new System.Drawing.Point(0, 79);
            openForm(new Telas.telaAluno());
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            this.activeBtn.Location = new System.Drawing.Point(0, 115);
            openForm(new Telas.telaTurma());
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            this.activeBtn.Location = new System.Drawing.Point(0, 151);
            openForm(new Telas.telaServico());
        }

        private void btnFinancas_Click(object sender, EventArgs e)
        {
            this.activeBtn.Location = new System.Drawing.Point(0, 187);
            openForm(new Telas.telaFinancas());
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            this.activeBtn.Location = new System.Drawing.Point(0, 223);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loaderPage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
