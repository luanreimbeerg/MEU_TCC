using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class LoginBusiness
    {
        DataBase.LoginDataBase db = new DataBase.LoginDataBase();

        public void Inserir(Model.Entities.tb_login log)
        {
            if (log.nm_usuario == string.Empty)
                throw new ArgumentException("O campo Usuário deve ser preenchido");
            if (log.nm_email == string.Empty)
                throw new ArgumentException("O campo Email deve ser preenchido");
            if (log.ds_senha == string.Empty)
                throw new ArgumentException("O campo Senha deve ser preenchido");

            db.Inserir(log);
        }

        //Se o modelo vir null, as credenciais estão inválidas, se não, efetua login
        public void VerificarUsuarioCliente(Model.Entities.tb_login log)
        {
            Model.Entities.tb_login verificado = db.VerificarUsuarioCliente(log);

            if (verificado == null)
                throw new ArgumentException("Credenciais inválidas");
            else
            {
                Model.Entities.UsuarioLogado.ID = verificado.id_login;
                Model.Entities.UsuarioLogado.usuario = verificado.nm_usuario;
                Model.Entities.UsuarioLogado.email = verificado.nm_email;
                Model.Entities.UsuarioLogado.tipo = verificado.ds_tipo;
                Model.Entities.UsuarioLogado.imagem = verificado.img_usuario;
            }
        }

        //Se o Usuario ou Email forem igual aos dados informados, ele mostra um erro para o usuário dizendo que já existe
        public void VerificarSeExisteCliente(Model.Entities.tb_login log)
        {
            Model.Entities.tb_login verificado = db.VerificarSeExisteCliente(log);

            if (verificado != null)
            {
                if (verificado.nm_usuario == log.nm_usuario)
                    throw new ArgumentException("O Usuário já está em uso");

                if (verificado.nm_email == log.nm_email)
                    throw new ArgumentException("O email já está em uso");
            }
        }

        public void AlterarSenha(Model.Entities.tb_login log)
        {
            db.AlterarSenha(log);
        }

        public void VerificarUsuarioGerente(Model.Entities.tb_login log)
        {
            Model.Entities.tb_login verificado = db.VerificarUsuarioGerente(log);

            if (verificado == null)
                throw new ArgumentException("Credenciais inválidas");
            else
            {
                Model.Entities.UsuarioLogado.ID = verificado.id_login;
                Model.Entities.UsuarioLogado.usuario = verificado.nm_usuario;
                Model.Entities.UsuarioLogado.email = verificado.nm_email;
                Model.Entities.UsuarioLogado.tipo = verificado.ds_tipo;
                Model.Entities.UsuarioLogado.horariologin = DateTime.Now;
                Model.Entities.UsuarioLogado.imagem = verificado.img_usuario;
            }
        }

        public void VerificarUsuarioPrestador(Model.Entities.tb_login log)
        {
            Model.Entities.tb_login verificado = db.VerificarUsuarioPrestador(log);

            if (verificado == null)
                throw new ArgumentException("Credenciais inválidas");
            else
            {
                Model.Entities.UsuarioLogado.ID = verificado.id_login;
                Model.Entities.UsuarioLogado.usuario = verificado.nm_usuario;
                Model.Entities.UsuarioLogado.email = verificado.nm_email;
                Model.Entities.UsuarioLogado.tipo = verificado.ds_tipo;
                Model.Entities.UsuarioLogado.imagem = verificado.img_usuario;
            }
        }

        public void VerificarSeExistePrestador(Model.Entities.tb_login log)
        {
            Model.Entities.tb_login verificado = db.VerificarSeExistePrestador(log);

            if (verificado.nm_usuario == log.nm_usuario)
                throw new ArgumentException("O Usuário já está em uso");

            if (verificado.nm_email == log.nm_email)
                throw new ArgumentException("O email já está em uso");

        }

        public void SalvarImagem(Model.Entities.tb_login user)
        {
            if (user.img_usuario == null)
                throw new ArgumentException("A imagem não foi selecionada");

            db.SalvarImagem(user);
        }

        public void DeletarConta(int id)
        {
            db.DeletarConta(id);
        }
    }
}
