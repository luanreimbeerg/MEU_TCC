using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class PrestadorBusiness
    {
        DataBase.PresatadorDatabase db = new DataBase.PresatadorDatabase();

        public void Inserir(Model.Entities.tb_prestador prest)
        {
            ValidarPrestador(prest);

            db.inserir(prest);
        }

        public List<Model.Entities.tb_prestador> ListarPorTodos()
        {
            List<Model.Entities.tb_prestador> list = db.ListarPrestTudo();

            return list;
        }

        public List<Model.Entities.tb_prestador> ListarPorTodosInativos()
        {
            List<Model.Entities.tb_prestador> list = db.ListarPrestTudoInativo();

            return list;
        }

        public List<Model.Entities.tb_prestador> ListarPorID(int id)
        {
            List<Model.Entities.tb_prestador> list = db.ListarPrestId(id);

            return list;
        }

        public List<Model.Entities.tb_prestador> ListarPorEntrada(string Cpf)
        {
            List<Model.Entities.tb_prestador> list = db.ListarPrestCpf(Cpf);

            return list;
        }

        public void Remover(int id)
        {
            db.Deletar(id);
        }

        public void Alterar(Model.Entities.tb_prestador prest)
        {
            ValidarPrestador(prest);
            
            db.Alterar(prest);
        }

        public void AceitarPrestador(int id)
        {
            db.AceitarPrestador(id);
        }

        public void RejeitarPestador(int id)
        {
            db.RejeitarPestador(id);
        }

        private void ValidarPrestador(Model.Entities.tb_prestador pres)
        {
            if (!Utils.Validacao.ValidarRequerido(pres.nm_prestador))
                throw new ArgumentException("O campo Nome é obrigatório");
            //if (!Utils.Validacao.ValidarCpf(emp.ds_cpf))
            //    throw new ArgumentException("O campo CPF é obrigatório");
            ////////if (!Utils.Validacao.ValidarRequerido(pres.uf_estado))
            ////////    throw new ArgumentException("O campo UF é obrigatório");
            if (!Utils.Validacao.ValidarRg(pres.ds_rg))
                throw new ArgumentException("O campo RG é obrigatório");
            if (!Utils.Validacao.ValidarCep(pres.ds_cep))
                throw new ArgumentException("O campo Cep deve ser preenchido");
            if (pres.end_prestador == " -  - " || !Utils.Validacao.ValidarRequerido(pres.end_prestador))
                throw new ArgumentException("Cep inválido");
            if (!Utils.Validacao.ValidarRequerido(pres.nu_prestador))
                throw new ArgumentException("O campo Nº é obrigatório");
            if (!Utils.Validacao.ValidarEmail(pres.ds_email))
                throw new ArgumentException("O Email é inválido");
            if (!Utils.Validacao.ValidarCelOuTel(pres.ds_cel))
                throw new ArgumentException("O Celular é inválido");
            if (!Utils.Validacao.ValidarCelOuTel(pres.ds_tel))
                throw new ArgumentException("O Telefone inválido");
            if (!Utils.Validacao.ValidarDt(pres.dt_nasc))
                throw new ArgumentException("A Data de nascimento é inválida");
            if (pres.ds_genero == string.Empty)
                throw new ArgumentException("O campo Gênero é obrigatório");
        }
    }
}
