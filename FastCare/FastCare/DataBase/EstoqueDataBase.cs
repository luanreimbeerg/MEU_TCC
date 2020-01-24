using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class EstoqueDataBase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void Inserir(Model.Entities.tb_estoque estoque)
        {
            db.tb_estoque.Add(estoque);
            db.SaveChanges();
        }

        public List<Model.Entities.tb_estoque> ListarTodos()
        {
            List<Model.Entities.tb_estoque> estock = db.tb_estoque.ToList();
            return estock;
        }

        public List<Model.Entities.tb_estoque> ListarTodosDistinct()
        {
            List<Model.Entities.tb_estoque> estock = db.tb_estoque.Distinct().ToList();
            return estock;
        }

        public List<Model.Entities.tb_estoque> ListarPorId(int id)
        {
            List<Model.Entities.tb_estoque> estockId = db.tb_estoque.Where(t => t.id_estoque == id).ToList();
            return estockId;
        }

        public Model.Entities.tb_estoque ListarPorIdModelo(int id)
        {
            Model.Entities.tb_estoque estockId = db.tb_estoque.FirstOrDefault(t => t.id_estoque == id);
            return estockId;
        }

        public List<Model.Entities.tb_estoque> ListarPorQuantidade(int quantidade)
        {
            List<Model.Entities.tb_estoque> estockEntrada = db.tb_estoque.Where(t => t.qt_produtos == quantidade).ToList();
            return estockEntrada;
        }

        public Model.Entities.tb_estoque ListarPorProduto(string produto)
        {
            Model.Entities.tb_estoque estockEntrada = db.tb_estoque.FirstOrDefault(t => t.tb_suprimento.nm_produto == produto);
            return estockEntrada;
        }

        public void Remover(int id)
        {
            Model.Entities.tb_estoque remove = db.tb_estoque.FirstOrDefault(t => t.id_estoque == id);
            db.tb_estoque.Remove(remove);

            db.SaveChanges();
        }

        public void Alterar(Model.Entities.tb_estoque estoque)
        {
            Model.Entities.tb_estoque antigo = db.tb_estoque.FirstOrDefault(t => t.id_estoque == estoque.id_estoque);

            antigo.id_suprimento = estoque.id_suprimento;
            antigo.qt_produtos = estoque.qt_produtos;

            db.SaveChanges();
        }

        public List<Model.Entities.tb_estoque> ListarOrdenadoPorQuantidade()
        {
            List<Model.Entities.tb_estoque> f = db.tb_estoque.OrderBy(t => t.qt_produtos).ToList();
            return f;
        }

        public List<Model.Entities.tb_estoque> ListarOrdenadoPorIdProduto()
        {
            List<Model.Entities.tb_estoque> f = db.tb_estoque.OrderBy(t => t.id_suprimento).ToList();
            return f;
        }
        public void Adcionar(Model.Entities.tb_estoque estoque)
        {
            Model.Entities.tb_estoque antigo = db.tb_estoque.FirstOrDefault(t => t.id_estoque == estoque.id_estoque);
            antigo.qt_produtos = estoque.qt_produtos;

            db.SaveChanges();
        }
    }
}
