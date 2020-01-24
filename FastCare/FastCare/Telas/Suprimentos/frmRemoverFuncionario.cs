using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.RH
{
    public partial class frmRemoverFuncionario : Form
    {
        public frmRemoverFuncionario()
        {
            InitializeComponent();

            ConsultarCpf();
        }
        
        private void ConsultarCpf()
        {
            Business.RHBusiness busrh = new Business.RHBusiness();
            List<Model.Entities.tb_funcionario> list = busrh.ListarPorTodos();

            cboCpf.DisplayMember = nameof(Model.Entities.tb_funcionario.ds_cpf);
            cboCpf.DataSource = list;
        }

        private void cboCpf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Entities.tb_funcionario func = cboCpf.SelectedItem as Model.Entities.tb_funcionario;

            txtCargo.Text = func.nm_cargo;
            txtCel.Text = func.ds_cel;
            txtCep.Text = func.ds_cep;
            txtCpf.Text = func.ds_cpf;
            txtEmail.Text = func.ds_email;
            txtEnd.Text = func.end_funcionario;
            txtNCasa.Text = func.nu_funcionario;
            txtNome.Text = func.nm_funcionario;
            txtRg.Text = func.ds_rg;
            txtTel.Text = func.ds_tel;
            nudSalario.Value = Convert.ToDecimal(func.qt_salario);
            nudVa.Value = Convert.ToDecimal(func.vl_va);
            nudVt.Value = Convert.ToDecimal(func.vl_vt);
            cboSetor.Text = func.ds_setor;
            cboUF.Text = func.uf_estado;
            dtpContratacao.Value = func.dt_contratacao;
            dtpNasc.Value = func.dt_nasc;

            if (func.ds_genero == "M")
                rdnM.Checked = true;
            else
                rdnF.Checked = true;

            if (func.est_civil == "Casado")
                rdnCasado.Checked = true;
            else
                rdnSolteiro.Checked = true;

            if (func.bl_va == true)
                chkVa.Checked = true;

            if (func.bl_vt == true)
                chkVt.Checked = true;
        }

        private void AcoesBeneficios()
        {
            if (chkVa.Checked == true || chkVt.Checked == true)
                lblvalores.Visible = true;
            else
                lblvalores.Visible = false;

            if (chkVa.Checked == true)
            {
                lblva.Visible = true;
                nudVa.Visible = true;
            }
            else
            {
                lblva.Visible = false;
                nudVa.Visible = false;
                nudVa.Value = 0;
            }

            if (chkVt.Checked == true)
            {
                lblvt.Visible = true;
                nudVt.Visible = true;
            }
            else
            {
                lblvt.Visible = false;
                nudVt.Visible = false;
                nudVt.Value = 0;
            }
        }

        private void chkVt_CheckedChanged(object sender, EventArgs e)
        {
            AcoesBeneficios();
        }

        private void chkVa_CheckedChanged(object sender, EventArgs e)
        {
            AcoesBeneficios();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model.Entities.tb_funcionario func = cboCpf.SelectedItem as Model.Entities.tb_funcionario;

            Business.RHBusiness busrh = new Business.RHBusiness();
            busrh.Remover(func.id_funcionario);

            MessageBox.Show("Remoção efetuada com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ConsultarCpf();
        }
    }
}
