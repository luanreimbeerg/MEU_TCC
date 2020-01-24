using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class LoginDataBase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void Inserir(Model.Entities.tb_login login)
        {
            db.tb_login.Add(login);
            db.SaveChanges();
        }

        public void AlterarSenha(Model.Entities.tb_login login)
        {
            Model.Entities.tb_login antigo = db.tb_login.FirstOrDefault(l => l.nm_email == login.nm_email);
            antigo.ds_senha = login.ds_senha;

            db.SaveChanges();
        }

        public Model.Entities.tb_login VerificarUsuarioGerente(Model.Entities.tb_login login)
        {
            Model.Entities.tb_login logado = db.tb_login.FirstOrDefault(l => l.nm_email == login.nm_email && l.ds_senha == login.ds_senha && l.ds_tipo == "Gerente");
            return logado;
        }

        public Model.Entities.tb_login VerificarUsuarioCliente(Model.Entities.tb_login login)
        {
            Model.Entities.tb_login logado = db.tb_login.FirstOrDefault(l => l.nm_email == login.nm_email && l.nm_usuario == login.nm_usuario && l.ds_tipo == "Cliente");
            return logado;
        }

        public Model.Entities.tb_login VerificarSeExisteCliente(Model.Entities.tb_login login)
        {
            Model.Entities.tb_login logado = db.tb_login.FirstOrDefault(l => l.nm_email == login.nm_email && l.ds_tipo == "Cliente" || l.nm_usuario == login.nm_usuario && l.ds_tipo == "Cliente");
            return logado;
        }

        public Model.Entities.tb_login VerificarUsuarioPrestador(Model.Entities.tb_login login)
        {
            Model.Entities.tb_login logado = db.tb_login.FirstOrDefault(l => l.nm_email == login.nm_email && l.ds_senha == login.ds_senha && l.ds_tipo == "Prestador");
            return logado;
        }
        public Model.Entities.tb_login VerificarSeExistePrestador(Model.Entities.tb_login login)
        {
            Model.Entities.tb_login logado = db.tb_login.FirstOrDefault(l => l.nm_email == login.nm_email && l.ds_tipo == "Prestador" || l.nm_usuario == login.nm_usuario && l.ds_tipo == "Prestador");
            return logado;
        }

        public void SalvarImagem(Model.Entities.tb_login user)
        {
            Model.Entities.tb_login antigo = db.tb_login.FirstOrDefault(t => t.id_login == user.id_login);

            antigo.img_usuario = user.img_usuario;

            db.SaveChanges();
        }

        public void DeletarConta(int id)
        {
            Model.Entities.tb_login conta = db.tb_login.FirstOrDefault(t => t.id_login == id);
            db.tb_login.Remove(conta);

            db.SaveChanges();
        }

    }
}
