using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Prestador
{
    public partial class frmAceitarRejeitar : Form
    {
        public frmAceitarRejeitar()
        {
            InitializeComponent();

            txtCel.Text = Model.Entities.Prestador.cel;
            txtCep.Text = Model.Entities.Prestador.cep;
            txtCpf.Text = Model.Entities.Prestador.cpf;
            txtEmail.Text = Model.Entities.Prestador.email;
            txtEnd.Text = Model.Entities.Prestador.endereco;
            txtNome.Text = Model.Entities.Prestador.nome;
            txtNu.Text = Model.Entities.Prestador.numero;
            txtRg.Text = Model.Entities.Prestador.rg;
            txtTel.Text = Model.Entities.Prestador.tel;
            cboSetor.Text = Model.Entities.Prestador.setor;
            cboUf.Text = Model.Entities.Prestador.uf;
            dtpNasc.Value = Model.Entities.Prestador.dt_nasc;

            if (Model.Entities.Prestador.genero == "M")
                rdnM.Checked = true;
            else
                rdnF.Checked = true;
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            APIs.ApiGmailSender gmail = new APIs.ApiGmailSender();
            Business.PrestadorBusiness buspre = new Business.PrestadorBusiness();
            buspre.AceitarPrestador(Model.Entities.Prestador.id);
            Business.LoginBusiness buslogin = new Business.LoginBusiness();
            Model.Entities.tb_login log = new Model.Entities.tb_login();

            log.ds_senha = "1234";
            log.nm_email = Model.Entities.Prestador.email;
            log.nm_usuario = "#user" + Model.Entities.Prestador.id.ToString();
            log.ds_tipo = "Prestador";

            buslogin.Inserir(log);

            string para = Model.Entities.Prestador.email;
            string assunto = "Fast Care - Seleção";
            string mensagem = "Parabens!!! seu perfil foi Aceito, entre com seu email e senha padrão '1234'. Você poderá trocar a qualquer momento em 'Meu Perfil' e 'Alterar Senha'";

            gmail.Enviar(para, assunto, mensagem);
            MessageBox.Show("O prestador está ativo agora", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmValidarPrestador tela = new frmValidarPrestador();
            tela.Show();
            Hide();
        }

        private void btnRejeitar_Click(object sender, EventArgs e)
        {
            APIs.ApiGmailSender gmail = new APIs.ApiGmailSender();
            Business.PrestadorBusiness buspre = new Business.PrestadorBusiness();
            buspre.RejeitarPestador(Model.Entities.Prestador.id);

            string para = Model.Entities.Prestador.email;
            string assunto = "Fast Care - Seleção";
            string mensagem = "O seu perfil foi Rejeitado";

            gmail.Enviar(para, assunto, mensagem);
            MessageBox.Show("O prestador foi Rejeitado", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmValidarPrestador tela = new frmValidarPrestador();
            tela.Show();
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
