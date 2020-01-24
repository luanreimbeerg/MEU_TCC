using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.FolhaPagamento
{
    public partial class frmpagamento : Form
    {
        public frmpagamento()
        {
            InitializeComponent();
        }

   

        

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void nudId_ValueChanged_1(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(nudId.Value);
            DateTime mes = dtpmesreferente.Value;
            Business.RHBusiness busi = new Business.RHBusiness();
            Business.PontoBusiness busponto = new Business.PontoBusiness();

            Model.Entities.tb_funcionario pag = busi.ListarFunciinario(ID);


            txtnome.Text = pag.nm_funcionario;
            txtfuncao.Text = pag.nm_cargo;
            nudsalario.Value = pag.qt_salario;
            nudVA.Value = Convert.ToDecimal(pag.vl_va);
            nudVt.Value = Convert.ToDecimal(pag.vl_vt);
            nudhoras.Value = busponto.BuscarHorasMes(ID, mes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal salario = nudsalario.Value;

            decimal horas = nudhoras.Value;
            decimal hora = salario / 202.5m;
            decimal extra = hora * 0.5m;
            decimal umahoraextra = hora + extra;

            decimal horaextra = umahoraextra * horas;
            nudhoraextra.Value = horaextra;

            decimal salariobase = salario + horaextra;
            nudsalariobase.Value = salariobase;
            decimal inss = 0;


            if (salariobase <= 1751.81m)
            {
                inss = salario * 0.08m;
                nudInss.Value = inss;

            }

            else if (salariobase >= 1751.82m || salario <= 2919.72m)

            {
                inss = salario * 0.09m;
                nudInss.Value = inss;
            }

            else if (salariobase >= 2919.73m || salario <= 5839.45m)

            {
                inss = salario * 0.011m;
                nudInss.Value = inss;
            }

            else if (salariobase > 5839.46m)

            {
                inss = salario * 0.015m;
                nudInss.Value = inss;

            }

            decimal FGTS = salariobase * 0.08m;
            nudFgts.Value = FGTS;

            decimal VT = nudVt.Value;
            decimal VA = nudVA.Value;

            decimal falta = Convert.ToDecimal(nudFaltas.Value);


            decimal faltas = salariobase / 30 * falta;
            nudfalta.Value = faltas;

            decimal totaldesc = inss + FGTS + VT + VA + faltas;
            nuddesconto.Value = totaldesc;
            decimal desconto = nuddesconto.Value;
            decimal salarioliquido = salariobase - desconto;
            nudliquido.Value = salarioliquido;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                Model.Entities.tb_pagamento pag = new Model.Entities.tb_pagamento();

                pag.id_funcionario = Convert.ToInt32(nudId.Value);
                pag.nm_funcionario = txtnome.Text;
                pag.desc_falta = Convert.ToDecimal(nudFaltas.Value);
                pag.dt_mes = dtpmesreferente.Value;
                pag.FGTS = Convert.ToDecimal(nudFgts.Value);
                pag.função = txtfuncao.Text;
                pag.horasextra = Convert.ToInt32(nudhoras.Value);
                pag.INSS = nudInss.Value;
                pag.nu_falta = Convert.ToInt32(nudFaltas.Value);
                pag.salario_base = Convert.ToDecimal(nudsalariobase.Value);
                pag.total_desconto = Convert.ToDecimal(nuddesconto.Value);
                pag.VA = Convert.ToDecimal(nudVA.Value);
                pag.VT = Convert.ToDecimal(nudVt.Value);
                pag.valor_liquido = Convert.ToDecimal(nudliquido.Value);
                pag.salario = Convert.ToDecimal(nudsalario.Value);
                pag.horaextraareceber = Convert.ToDecimal(nudhoraextra.Value);

                Business.BusinessPagamento businessPagamento = new Business.BusinessPagamento();
                businessPagamento.Inserir(pag);

                MessageBox.Show("Cadastrado com sucesso", "Folha salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button4_Click(object sender, EventArgs e)
        {
            frmpagamento tela = new frmpagamento();
            Utils.ImprimirTela Impressoes = new Utils.ImprimirTela();
            Impressoes.Imprimir(tela, panelRecibo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
        }
    }
}
