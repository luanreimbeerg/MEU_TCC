﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Cliente.Servico
{
    public partial class frmHistoricoCompras : Form
    {
        public frmHistoricoCompras()
        {
            InitializeComponent();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
