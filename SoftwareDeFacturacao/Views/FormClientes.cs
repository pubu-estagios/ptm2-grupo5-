﻿using System;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void addAluno_Click(object sender, EventArgs e)
        {
            FormCadastroClientes fr = new FormCadastroClientes();
            fr.ShowDialog();
        }
    }
}
