using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class SuprimentosDataBase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void Inserir(Model.Entities.tb_suprimento supri)
        {
            db.tb_suprimento.Add(supri);
            db.SaveChanges();
        }

        public List<Model.Entities.tb_suprimento> ListarTodos()
        {
            List<Model.Entities.tb_suprimento> supri = db.tb_suprimento.ToList();
            return supri;
        }

        public List<string> ListarTodosDistinct()
        {
            List<string> supri = db.tb_suprimento.Select( t=> t.nm_produto).Distinct().ToList();
            return supri;
        }

        public  List<Model.Entities.tb_suprimento> ListarPorId(int id)
        {
            List<Model.Entities.tb_suprimento> supriId = db.tb_suprimento.Where(t => t.id_suprimento == id).ToList();
            return supriId;
        }

        public Model.Entities.tb_suprimento ListarPorIdModelo(int id)
        {
            Model.Entities.tb_suprimento supriId = db.tb_suprimento.FirstOrDefault(t => t.id_suprimento == id);
            return supriId;
        }

        public List<Model.Entities.tb_suprimento> ListarPorProduto(string Produto)
        {
            List<Model.Entities.tb_suprimento> supriProdutos = db.tb_suprimento.Where(t => t.nm_produto.Contains(Produto)).ToList();
            return supriProdutos;
        }

        public List<Model.Entities.tb_suprimento> ListarPorProdutoDecrescente(string Produto)
        {
            List<Model.Entities.tb_suprimento> supriProdutos = db.tb_suprimento.Where(t => t.nm_produto.Contains(Produto)).OrderByDescending(t=> t.id_suprimento).ToList();
            return supriProdutos;
        }

        public void Remover(int id)
        {
            Model.Entities.tb_suprimento remove = db.tb_suprimento.FirstOrDefault(t => t.id_suprimento == id);
            db.tb_suprimento.Remove(remove);
        
            db.SaveChanges();
        }

        public void Alterar(Model.Entities.tb_suprimento supri)
        {
            Model.Entities.tb_suprimento antigo = db.tb_suprimento.FirstOrDefault(t => t.id_suprimento == supri.id_suprimento);

            antigo.nm_produto = supri.nm_produto;
            antigo.qt_produtos = supri.qt_produtos;
            antigo.vl_preco = supri.vl_preco;
            antigo.id_fornecedor = supri.id_fornecedor;

            db.SaveChanges();
        }

        public List<Model.Entities.tb_suprimento> ListarOrdenadoPorProduto()
        {
            List<Model.Entities.tb_suprimento> supri = db.tb_suprimento.OrderBy(t => t.nm_produto).ToList();
            return supri;
        }

        public List<Model.Entities.tb_suprimento> ListarOrdenadoPorFornecedor()
        {
            List<Model.Entities.tb_suprimento> supri = db.tb_suprimento.OrderBy(t => t.id_fornecedor).ToList();
            return supri;
        }

        public List<Model.Entities.tb_suprimento> ListarOrdenadoPorQuantidade()
        {
            List<Model.Entities.tb_suprimento> supri = db.tb_suprimento.OrderBy(t => t.qt_produtos).ToList();
            return supri;
        }

        public List<Model.Entities.tb_suprimento> ListarOrdenadoPorIDSuprimento()
        {
            List<Model.Entities.tb_suprimento> supri = db.tb_suprimento.OrderBy(t => t.id_suprimento).ToList();
            return supri;
        }

        public List<Model.Entities.tb_suprimento> ListarOrdenadoPorPreco()
        {
            List<Model.Entities.tb_suprimento> supri = db.tb_suprimento.OrderBy(t => t.vl_preco).ToList();
            return supri;
        }
    }
}
