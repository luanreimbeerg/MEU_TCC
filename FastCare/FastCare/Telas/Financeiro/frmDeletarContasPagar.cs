﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Financeiro
{
    public partial class frmDeletarContasPagar : Form
    {
        public frmDeletarContasPagar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);

            Business.DespesaBusiness busConta = new Business.DespesaBusiness();
            busConta.remover(id);

            MessageBox.Show("Remoção efetuada com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);
            
            Business.DespesaBusiness busIdModelo = new Business.DespesaBusiness();
            Model.Entities.tb_conta modelo = busIdModelo.listarPOrIDModeloDespesa(id);

            if (modelo != null)
            {
                txtConta.Text = modelo.nm_conta;
                nudValor.Value = modelo.vl_conta;
                dtpPagamento.Value = Convert.ToDateTime(modelo.dt_pagamento);
                dtpVencimento.Value = Convert.ToDateTime(modelo.dt_vencimento);
                if (modelo.bl_situacao == true)
                    rdnPaga.Checked = true;
                else
                    rdnPendente.Checked = true;
            }

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
