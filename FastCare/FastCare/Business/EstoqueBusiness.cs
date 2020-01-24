using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class EstoqueBusiness
    {
        public void Inserir(Model.Entities.tb_estoque estock)
        {
            //if (cliente.ds_cel == string.Empty)
                //throw new ArgumentException(" o campo Celular è obrigatorio");
           // if (cliente.ds_cep == string.Empty)
              //  throw new ArgumentException(" o campo CEP è obrigatorio");
           // if (cliente.ds_cpf == string.Empty)
               // throw new ArgumentException(" o campo CPF è obrigatorio");
          // if (cliente.ds_email == string.Empty)
               // throw new ArgumentException(" o campo Celular è obrigatorio");
          //  if (cliente.ds_rg == string.Empty)
               //throw new ArgumentException(" o campo RG è obrigatorio");
           // if (cliente.ds_tel == string.Empty)
               // throw new ArgumentException(" o campo TELEFONE è obrigatorio");
           // if (cliente.dt_nasc > DateTime.Now)
               // throw new ArgumentException(" o campo NASCIMENTO deve ser preenchido corretamente");
          //  if (cliente.end_cliente == string.Empty)
               // throw new ArgumentException(" o campo ENDEREÇO è obrigatorio");
          //  if (cliente.nm_cliente == string.Empty)
               // throw new ArgumentException(" o campo NOME è obrigatorio");
           // if (cliente.nu_cliente == string.Empty)
               // throw new ArgumentException(" o campo Nº CASA è obrigatorio");
           // if (cliente.UF_estado == string.Empty)
              //  throw new ArgumentException(" o campo ESTADO è obrigatorio");

            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            db.Inserir(estock);
        }

        public List<Model.Entities.tb_estoque> ListarPorTodos()
        {
            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            List<Model.Entities.tb_estoque> list = db.ListarTodos();

            return list;
        }

        public List<Model.Entities.tb_estoque> ListarPorTodosDistinct()
        {
            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            List<Model.Entities.tb_estoque> list = db.ListarTodosDistinct();

            return list;
        }

        public List<Model.Entities.tb_estoque> ListarPorID(int id)
        {
            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            List<Model.Entities.tb_estoque> list = db.ListarPorId(id);

            return list;
        }

        public Model.Entities.tb_estoque ListarPorIdModelo(int id)
        {
            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            Model.Entities.tb_estoque list = db.ListarPorIdModelo(id);

            return list;
        }

        public List<Model.Entities.tb_estoque> ListarPorQuantidade(int quantidade)
        {
            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            List<Model.Entities.tb_estoque> list = db.ListarPorQuantidade(quantidade);

            return list;
        }

        public Model.Entities.tb_estoque ListarPorProduto(string produto)
        {
            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            Model.Entities.tb_estoque modelo = db.ListarPorProduto(produto);

            return modelo;
        }

        public void Remover(int id)
        {
            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            db.Remover(id);
        }

        public void Alterar(Model.Entities.tb_estoque estoque)
        {
            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            db.Alterar(estoque);
        }
        public List<Model.Entities.tb_estoque> ListarTodosPorOrdem(string ordem)
        {
            DataBase.EstoqueDataBase dbE = new DataBase.EstoqueDataBase();
            List<Model.Entities.tb_estoque> lista = new List<Model.Entities.tb_estoque>();

            if (ordem == "Quantidade")
                lista = dbE.ListarOrdenadoPorQuantidade();

            if (ordem == "ID Produto")
                lista = dbE.ListarOrdenadoPorIdProduto();

            return lista;
        }
        public void Adicionar(Model.Entities.tb_estoque estoque)
        {
            DataBase.EstoqueDataBase db = new DataBase.EstoqueDataBase();
            db.Adcionar(estoque);
        }

    }
}
