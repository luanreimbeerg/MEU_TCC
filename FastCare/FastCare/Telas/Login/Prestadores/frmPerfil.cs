using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Login.Prestadores
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();

            //Business.ServicosBusiness busserv = new Business.ServicosBusiness();
            //lblCell.Text = Model.Entities.Prestador.cel;
            //lblEmaill.Text = Model.Entities.UsuarioLogado.email;
            //lblUser.Text = Model.Entities.UsuarioLogado.usuario;

            //if (Model.Entities.UsuarioLogado.imagem != null)
            //{
            //    Utils.ConversorImagem convert = new Utils.ConversorImagem();
            //    imgGerente.Image = convert.ConverterParaImagem(Model.Entities.UsuarioLogado.imagem);
            //}

            //if (Model.Entities.Prestador.genero == "F")
            //    imgGenero.Image = Properties.Resources.F;
            //else
            //    imgGenero.Image = Properties.Resources.M;

            //int servicos = busserv.ServicosRealizados(Model.Entities.Prestador.id);

            //lblServicos.Text = servicos.ToString() + "Serviços realizados";


        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void imgTrocar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "imagem (*.PNG;*.JPG;*.JPEG)|*.PNG;*.JPG;*.JPEG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Model.Entities.tb_login user = new Model.Entities.tb_login();
                Utils.ConversorImagem convert = new Utils.ConversorImagem();
                imgGerente.Load(openFileDialog1.FileName);
                byte[] imagem = convert.ConverterParaByte(imgGerente.Image);

                user.id_login = Model.Entities.UsuarioLogado.ID;
                user.img_usuario = imagem;

                Business.LoginBusiness buslogin = new Business.LoginBusiness();
                buslogin.SalvarImagem(user);

                MessageBox.Show("Foto salva com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Model.Entities.UsuarioLogado.imagem = imagem;
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            Telas.Login.Gerente.frmAlterarSenha tela = new Gerente.frmAlterarSenha();
            tela.Show();
            Hide();
        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir essa conta?", "Fast Care", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) ;
            {
                Business.LoginBusiness buslogin = new Business.LoginBusiness();
                buslogin.DeletarConta(Model.Entities.UsuarioLogado.ID);

                MessageBox.Show("Sua conta foi deletada", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Telas.Outros.frmLogar tela = new Outros.frmLogar();
                tela.Show();
                Hide();
            }
        }
    } }
