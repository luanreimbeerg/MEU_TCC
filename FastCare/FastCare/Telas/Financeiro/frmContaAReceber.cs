using System;
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
    public partial class frmContaAReceber : Form
    {
        public frmContaAReceber()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_conta conta = new Model.Entities.tb_conta();

                conta.ds_tipo = "Receita";
                conta.dt_vencimento = dtpVencimento.Value;
                conta.nm_conta = txtConta.Text;
                conta.dt_pagamento = dtpPagamento.Value;
                conta.vl_conta = nudValor.Value;

                if (rdnPaga.Checked == true)
                    conta.bl_situacao = true;
                else
                    conta.bl_situacao = false;

                Business.DespesaBusiness busdespesa = new Business.DespesaBusiness();
                busdespesa.Inserir(conta);

                MessageBox.Show("Cadastro efetuado com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(196, 231, 167);
            button1.ForeColor = Color.Black;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.ForeColor = Color.FromArgb(196, 231, 167);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
