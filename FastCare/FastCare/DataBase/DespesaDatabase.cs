using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class DespesaDatabase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void Inserir(Model.Entities.tb_conta c)
        {
            db.tb_conta.Add(c);
            db.SaveChanges();
        }

        public List<Model.Entities.tb_conta> ListarTodos()
        {
            List<Model.Entities.tb_conta> d = db.tb_conta.ToList();
            return d;
        }

        public List<Model.Entities.tb_conta> ListarPorId(int id)
        {
            List<Model.Entities.tb_conta> dID = db.tb_conta.Where(t => t.id_conta == id).ToList();
            return dID;
        }

        public Model.Entities.tb_conta ListarPorIdModeloReceita(int id)
        {
            Model.Entities.tb_conta dID = db.tb_conta.FirstOrDefault(t => t.id_conta == id && t.ds_tipo == "Receita");
            return dID;
        }

        public Model.Entities.tb_conta ListarPorIdModeloDespesa(int id)
        {
            Model.Entities.tb_conta dID = db.tb_conta.FirstOrDefault(t => t.id_conta == id && t.ds_tipo == "Despesas");
            return dID;
        }


        public List<Model.Entities.tb_conta> ListarPorNomeDespesa(string despesa)
        {
            List<Model.Entities.tb_conta> dNome = db.tb_conta.Where(t => t.nm_conta== despesa).ToList();
            return dNome;
        }
        public void Remover(int id)
        {
            Model.Entities.tb_conta remove = db.tb_conta.FirstOrDefault(t => t.id_conta == id);
            db.tb_conta.Remove(remove);

            db.SaveChanges();
        }

        public void Alterar(Model.Entities.tb_conta d)
        {
            Model.Entities.tb_conta antigo = db.tb_conta.FirstOrDefault(t => t.id_conta == d.id_conta);

            antigo.dt_pagamento = d.dt_pagamento;
            antigo.dt_vencimento = d.dt_vencimento;
            antigo.ds_tipo = d.ds_tipo; ;
            antigo.nm_conta = d.nm_conta;
            antigo.vl_conta = d.vl_conta;


            db.SaveChanges();
        }

        public List<Model.Entities.tb_conta> ListarOrdenadoPorValorR()
        {
            List<Model.Entities.tb_conta> f = db.tb_conta.Where(t => t.ds_tipo == "Receita").OrderBy(t => t.vl_conta).ToList();
            return f;
        }
        public List<Model.Entities.tb_conta> ListarOrdenadoPorNomeR()
        {
            List<Model.Entities.tb_conta> f = db.tb_conta.Where(t => t.ds_tipo == "Receita").OrderBy(t => t.nm_conta).ToList();
            return f;
        }
        public List<Model.Entities.tb_conta> ListarOrdenadoPorSituacaoR()
        {
            List<Model.Entities.tb_conta> f = db.tb_conta.Where(t=> t.ds_tipo == "Receita").OrderBy(t => t.bl_situacao).ToList();
            return f;
        }

        public List<Model.Entities.tb_conta> ListarOrdenadoPorValorD()
        {
            List<Model.Entities.tb_conta> f = db.tb_conta.Where(t => t.ds_tipo == "Despesas").OrderBy(t => t.vl_conta).ToList();
            return f;
        }
        public List<Model.Entities.tb_conta> ListarOrdenadoPorNomeD()
        {
            List<Model.Entities.tb_conta> f = db.tb_conta.Where(t => t.ds_tipo == "Despesas").OrderBy(t => t.nm_conta).ToList();
            return f;
        }
        public List<Model.Entities.tb_conta> ListarOrdenadoPorSituacaoD()
        {
            List<Model.Entities.tb_conta> f = db.tb_conta.Where(t => t.ds_tipo == "Despesas").OrderBy(t => t.bl_situacao).ToList();
            return f;
        }

    }
}
