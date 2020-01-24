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
    public partial class frmCadastrarConta : Form
    {
        public frmCadastrarConta()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_conta conta = new Model.Entities.tb_conta();

                conta.ds_tipo = "Despesas";
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

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(196, 231, 167);
            button2.ForeColor = Color.Black;
        }

        private void ImgBack_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.ForeColor = Color.FromArgb(196, 231, 167);
        }
    }
}
