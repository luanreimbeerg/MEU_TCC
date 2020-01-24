using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class RHBusiness
    {
        public void Inserir(Model.Entities.tb_funcionario emp)
        {
            ValidarFuncinario(emp);

            DataBase.RHDataBase db = new DataBase.RHDataBase();
            db.Inserir(emp);
        }

        public List<Model.Entities.tb_funcionario> ListarPorTodos()
        {
            DataBase.RHDataBase db = new DataBase.RHDataBase();
            List<Model.Entities.tb_funcionario> list = db.ListarTodos();

            return list;
        }


        public Model.Entities.tb_funcionario ListarFunciinario(int id)
        {
            DataBase.RHDataBase db = new DataBase.RHDataBase();
            Model.Entities.tb_funcionario list = db.ListarFuncionario(id);

            return list;
        }

        public List<Model.Entities.tb_funcionario> ListarPorID(int id)
        {
            DataBase.RHDataBase db = new DataBase.RHDataBase();
            List<Model.Entities.tb_funcionario> list = db.ListarPorId(id);

            return list;
        }

        public List<Model.Entities.tb_funcionario> ListarPorCpf(string Cpf)
        {
            DataBase.RHDataBase db = new DataBase.RHDataBase();
            List<Model.Entities.tb_funcionario> list = db.ListarPorCpf(Cpf);

            return list;
        }
        public void Remover(int id)
        {
            DataBase.RHDataBase db = new DataBase.RHDataBase();
            db.Remover(id);
        }

        public void Alterar(Model.Entities.tb_funcionario emp)
        {
            ValidarFuncinario(emp);

            DataBase.RHDataBase db = new DataBase.RHDataBase();
            db.Alterar(emp);
        }

        public List<Model.Entities.tb_funcionario> ListarTodosPorOrdem(string ordem)
        {
            DataBase.RHDataBase dbrh = new DataBase.RHDataBase();
            List<Model.Entities.tb_funcionario> lista = new List<Model.Entities.tb_funcionario>();

            if (ordem == "ID Funcionario")
                lista = dbrh.ListarOrdenadoPorId();

            if (ordem == "Funcionario")
                lista = dbrh.ListarOrdenadoPorNome();

            if (ordem == "Salario")
                lista = dbrh.ListarOrdenadoPorSalario();

            if (ordem == "Dt. Contratação")
                lista = dbrh.ListarOrdenadoPorContratacao();

            if (ordem == "Vale Transporte")
                lista = dbrh.ListarOrdenadoPorvt();

            if (ordem == "Vale Alimentação")
                lista = dbrh.ListarOrdenadoPorVa();

            if (ordem == "UF")
                lista = dbrh.ListarOrdenadoPorEstado();

            if (ordem == "Cargo")
                lista = dbrh.ListarOrdenadoPorCargo();

            if (ordem == "Setor")
                lista = dbrh.ListarOrdenadoPorSetor();

            if (ordem == "Estado Civil")
                lista = dbrh.ListarOrdenadoPorEstadoCivil();

            if (ordem == "Nascimento")
                lista = dbrh.ListarOrdenadoPorNascimento();

            if (ordem == "Genero")
                lista = dbrh.ListarOrdenadoPorgenero();

            return lista;
        }

        private void ValidarFuncinario(Model.Entities.tb_funcionario emp)
        {
            if (!Utils.Validacao.ValidarRequerido(emp.nm_funcionario))
                throw new ArgumentException("O campo Nome é obrigatório");
            //if (!Utils.Validacao.ValidarCpf(emp.ds_cpf))
            //    throw new ArgumentException("O campo CPF é obrigatório");
            if (!Utils.Validacao.ValidarRequerido(emp.uf_estado))
                throw new ArgumentException("O campo UF é obrigatório");
            if (!Utils.Validacao.ValidarRg(emp.ds_rg))
                throw new ArgumentException("O campo RG é obrigatório");
            if (!Utils.Validacao.ValidarCep(emp.ds_cep))
                throw new ArgumentException("O campo Cep deve ser preenchido");
            if (emp.end_funcionario == " -  - " || !Utils.Validacao.ValidarRequerido(emp.end_funcionario))
                throw new ArgumentException("Cep inválido");
            if (!Utils.Validacao.ValidarRequerido(emp.nu_funcionario))
                throw new ArgumentException("O campo Nº Estabelecimento é obrigatório");
            if (!Utils.Validacao.ValidarEmail(emp.ds_email))
                throw new ArgumentException("O Email é inválido");
            if (!Utils.Validacao.ValidarCelOuTel(emp.ds_cel))
                throw new ArgumentException("O Celular é inválido");
            if (!Utils.Validacao.ValidarCelOuTel(emp.ds_tel))
                throw new ArgumentException("O Telefone inválido");
            if (!Utils.Validacao.ValidarDt(emp.dt_nasc))
                throw new ArgumentException("A Data de nascimento é inválida");
            if (emp.dt_nasc >= emp.dt_contratacao)
                throw new ArgumentException("A Data de contratação é inválida");
        }
    }
}
