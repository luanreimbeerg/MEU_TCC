using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class FonecedorBusiness
    {
        DataBase.FornecedorDataBase db = new DataBase.FornecedorDataBase();

        public void Inserir(Model.Entities.tb_fornecedor forn)
        {
            Model.Entities.tb_fornecedor verificado = db.VerificarCnpj(forn.ds_cnpj);

            if (verificado != null)
                throw new ArgumentException("O CNPJ já existe");

            ValidarFornecedor(forn);

            db.Inserir(forn);
        }

        public List<Model.Entities.tb_fornecedor> ListarPorTodos()
        {
            List<Model.Entities.tb_fornecedor> list = db.ListarTodos();

            return list;
        }

        public List<Model.Entities.tb_fornecedor> ListarPorID(int id)
        {
            List<Model.Entities.tb_fornecedor> list = db.ListarPorId(id);

            return list;
        }

        public List<Model.Entities.tb_fornecedor> ListarPorNome(string nome)
        {
            List<Model.Entities.tb_fornecedor> list = db.ListarPorNome(nome);

            return list;
        }
        public void Remover(int id)
        {
            db.Remover(id);
        }

        public void Alterar(Model.Entities.tb_fornecedor forn)
        {
            Model.Entities.tb_fornecedor verificado = db.VerificarCnpj(forn.ds_cnpj);

            if (verificado != null)
                throw new ArgumentException("O CNPJ já existe");

            ValidarFornecedor(forn);

            db.Alterar(forn);
        }

        public void AlterarCnpjIgual(Model.Entities.tb_fornecedor forn)
        {
            ValidarFornecedor(forn);
            db.Alterar(forn);
        }

        public List<Model.Entities.tb_fornecedor> ListarTodosPorOrdem(string ordem)
        {
            List<Model.Entities.tb_fornecedor> lista = new List<Model.Entities.tb_fornecedor>();

            if (ordem == "UF")
                lista = db.ListarOrdenadoPorUF();
            if (ordem == "Fornecedor")
                lista = db.ListarOrdenadoPorFornecedor();
            if (ordem == "CNPJ")
                lista = db.ListarOrdenadoPorCnpj();
            if (ordem == "Endereço")
                lista = db.ListarOrdenadoPorEnd();

            return lista;
        }

        private void ValidarFornecedor(Model.Entities.tb_fornecedor forn)
        {
            if (!Utils.Validacao.ValidarRequerido(forn.nm_forn))
                throw new ArgumentException("O campo Fornecedor é obrigatório");
            if (!Utils.Validacao.ValidarCnpj(forn.ds_cnpj))
                throw new ArgumentException("O campo CNPJ é obrigatório");
            if (!Utils.Validacao.ValidarRequerido(forn.uf_estado))
                throw new ArgumentException("O campo UF é obrigatório");
            if (!Utils.Validacao.ValidarRequerido(forn.insc_estadual))
                throw new ArgumentException("O campo Inscrição Estadual é obrigatório");
            if (!Utils.Validacao.ValidarCep(forn.ds_cep))
                throw new ArgumentException("O campo Cep deve ser preenchido");
            if (forn.end_forn == " -  - " || !Utils.Validacao.ValidarRequerido(forn.end_forn))
                throw new ArgumentException("Cep inválido");
            if (!Utils.Validacao.ValidarRequerido(forn.nu_forn))
                throw new ArgumentException("O campo Nº Estabelecimento é obrigatório");
            if (!Utils.Validacao.ValidarEmail(forn.ds_email))
                throw new ArgumentException("O Email é inválido");
            if (!Utils.Validacao.ValidarCelOuTel(forn.ds_cel))
                throw new ArgumentException("O Celular é inválido");
            if (!Utils.Validacao.ValidarCelOuTel(forn.ds_tel))
                throw new ArgumentException("O Telefone inválido");
        }
    }
}
