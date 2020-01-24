using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class SuprimentosBusiness
    {

        public void Inserir(Model.Entities.tb_suprimento supri)
        {
            if (supri.nm_produto == string.Empty)
                throw new ArgumentException("Preencha o campo Produto");
            if(supri.qt_produtos == 0)
                throw new ArgumentException("Informe a Quantidade de Produtos");


            DataBase.SuprimentosDataBase db = new DataBase.SuprimentosDataBase();
            db.Inserir(supri);
        }

        public List<Model.Entities.tb_suprimento> ListarPorTodos()
        {
            DataBase.SuprimentosDataBase db = new DataBase.SuprimentosDataBase();
            List<Model.Entities.tb_suprimento> list = db.ListarTodos();

            return list;
        }

        public List<string> ListarPorTodosDistinct()
        {
            DataBase.SuprimentosDataBase db = new DataBase.SuprimentosDataBase();
            List<string> list = db.ListarTodosDistinct();

            return list;
        }

        public List<Model.Entities.tb_suprimento> ListarPorID(int id)
        {
            DataBase.SuprimentosDataBase db = new DataBase.SuprimentosDataBase();
            List<Model.Entities.tb_suprimento> list = db.ListarPorId(id);

            return list;
        }

        public Model.Entities.tb_suprimento ListarPorIdModelo(int id)
        {
            DataBase.SuprimentosDataBase db = new DataBase.SuprimentosDataBase();
            Model.Entities.tb_suprimento list = db.ListarPorIdModelo(id);

            return list;
        }

        public List<Model.Entities.tb_suprimento> ListarPorProduto(string Produto)
        {
            DataBase.SuprimentosDataBase db = new DataBase.SuprimentosDataBase();
            List<Model.Entities.tb_suprimento> list = db.ListarPorProduto(Produto);

            return list;
        }

        public List<Model.Entities.tb_suprimento> ListarPorProdutoDecrescente(string Produto)
        {
            DataBase.SuprimentosDataBase db = new DataBase.SuprimentosDataBase();
            List<Model.Entities.tb_suprimento> list = db.ListarPorProdutoDecrescente(Produto);

            return list;
        }

        public void Remover(int id)
        {
            DataBase.SuprimentosDataBase db = new DataBase.SuprimentosDataBase();
            db.Remover(id);
        }

        public void Alterar(Model.Entities.tb_suprimento supri)
        {
            if (supri.nm_produto == string.Empty)
                throw new ArgumentException("Preencha o campo Produto");
            if (supri.qt_produtos == 0)
                throw new ArgumentException("Informe a Quantidade de Produtos");

            DataBase.SuprimentosDataBase db = new DataBase.SuprimentosDataBase();
            db.Alterar(supri);
        }

        public List<Model.Entities.tb_suprimento> ListarPorOrdem(string ordem)
        {
            DataBase.SuprimentosDataBase dbsupri = new DataBase.SuprimentosDataBase();
            List<Model.Entities.tb_suprimento> lista = new List<Model.Entities.tb_suprimento>();

            if (ordem == "ID Suprimento")
                lista = dbsupri.ListarOrdenadoPorIDSuprimento();

            if (ordem == "ID Fornecedor")
                lista = dbsupri.ListarOrdenadoPorFornecedor();

            if (ordem == "Produto")
                lista = dbsupri.ListarOrdenadoPorProduto();

            if (ordem == "Quantidade")
                lista = dbsupri.ListarOrdenadoPorQuantidade();

            if (ordem == "Valor")
                lista = dbsupri.ListarOrdenadoPorPreco();

            return lista;
        }
    }
}
