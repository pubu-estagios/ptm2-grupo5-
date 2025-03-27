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
    public partial class FormConfigSistema : Form
    {
        public FormConfigSistema()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCorTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCorTema.SelectedItem.ToString())
            {
                case "Azul":
                    panelCorTema.BackColor = Color.Blue ;
                    break;
                case "Verde":
                    panelCorTema.BackColor = Color.Green;
                    break;
                case "Vermelho":
                    panelCorTema.BackColor = Color.Red;
                    break;
                default:
                    panelCorTema.BackColor = SystemColors.Control;
                    break;
            }
        }

        private void btnSelecionarLogotipo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    bunifuImageButtonLogotipo.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownImpostoAplicavel.Maximum = 0;
            numericUpDownImpostoAplicavel.Maximum = 100;
        }
    }
}
