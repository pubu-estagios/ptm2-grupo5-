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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void addAluno_Click(object sender, EventArgs e)
        {
            Form1CadastrarProdutos fr = new Form1CadastrarProdutos();
            fr.ShowDialog();
            
        }
    }
}
