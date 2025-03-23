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

        private void btnTurma_Click(object sender, EventArgs e)
        {

        }

        private void maximizeMenu_Click(object sender, EventArgs e)
        {
            this.maximizeMenu.Visible = false;
            this.minizeMenu.Visible = true;
            this.menuPrincipal.Size = new System.Drawing.Size(40, 457);
        }

        private void btnControlo_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
