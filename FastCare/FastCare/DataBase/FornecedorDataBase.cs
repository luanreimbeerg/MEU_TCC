using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class FornecedorDataBase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void Inserir(Model.Entities.tb_fornecedor forn)
        {
            db.tb_fornecedor.Add(forn);
            db.SaveChanges();
        }

        public List<Model.Entities.tb_fornecedor> ListarTodos()
        {
            List<Model.Entities.tb_fornecedor> forn = db.tb_fornecedor.ToList();
            return forn;
        }

        public List<Model.Entities.tb_fornecedor> ListarPorId(int id)
        {
            List<Model.Entities.tb_fornecedor> finId = db.tb_fornecedor.Where(t => t.id_fornecedor == id).ToList();
            return finId;
        }

        public List<Model.Entities.tb_fornecedor> ListarPorNome(string nome)
        {
            List<Model.Entities.tb_fornecedor> fornNome = db.tb_fornecedor.Where(t => t.nm_forn.Contains(nome)).ToList();
            return fornNome;
        }
        public void Remover(int id)
        {
            Model.Entities.tb_fornecedor remove = db.tb_fornecedor.FirstOrDefault(t => t.id_fornecedor == id);
            db.tb_fornecedor.Remove(remove);

            db.SaveChanges();
        }

        public void Alterar(Model.Entities.tb_fornecedor forn)
        {
            Model.Entities.tb_fornecedor antigo = db.tb_fornecedor.FirstOrDefault(t => t.ds_cnpj == forn.ds_cnpj);

            antigo.ds_cel = forn.ds_cel;
            antigo.ds_cep = forn.ds_cep;
            antigo.ds_cnpj = forn.ds_cnpj;
            antigo.ds_email = forn.ds_email;
            antigo.ds_tel = forn.ds_tel;
            antigo.end_forn = forn.end_forn;
            antigo.insc_estadual = forn.insc_estadual;
            antigo.nm_forn = forn.nm_forn;
            antigo.nu_forn = forn.nu_forn;
            antigo.uf_estado = forn.uf_estado;
            antigo.insc_estadual = forn.insc_estadual;

            db.SaveChanges();
        }

        public List<Model.Entities.tb_fornecedor> ListarOrdenadoPorUF()
        {
            List<Model.Entities.tb_fornecedor> f = db.tb_fornecedor.OrderBy(t => t.uf_estado).ToList();
            return f;
        }

        public List<Model.Entities.tb_fornecedor> ListarOrdenadoPorEnd()
        {
            List<Model.Entities.tb_fornecedor> f = db.tb_fornecedor.OrderBy(t => t.end_forn).ToList();
            return f;
        }

        public List<Model.Entities.tb_fornecedor> ListarOrdenadoPorCnpj()
        {
            List<Model.Entities.tb_fornecedor> f = db.tb_fornecedor.OrderBy(t => t.ds_cnpj).ToList();
            return f;
        }

        public List<Model.Entities.tb_fornecedor> ListarOrdenadoPorFornecedor()
        {
            List<Model.Entities.tb_fornecedor> f = db.tb_fornecedor.OrderBy(t => t.nm_forn).ToList();
            return f;
        }

        public Model.Entities.tb_fornecedor VerificarCnpj(string cnpj)
        {
            Model.Entities.tb_fornecedor model = db.tb_fornecedor.FirstOrDefault(t => t.ds_cnpj == cnpj);
            return model;
        }
    }
}
