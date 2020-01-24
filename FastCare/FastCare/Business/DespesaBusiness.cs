using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class DespesaBusiness
    {
        DataBase.DespesaDatabase db = new DataBase.DespesaDatabase();

        public void Inserir(Model.Entities.tb_conta conta)
        {
            ValidarConta(conta);
            db.Inserir(conta);
        }

        private void ValidarConta(Model.Entities.tb_conta conta)
        {
            if (!Utils.Validacao.ValidarRequerido(conta.nm_conta))
                throw new ArgumentException("O campo Nome da Conta é obrigatório");
            if (!Utils.Validacao.ValidarRequerido(conta.ds_tipo))
                throw new ArgumentException("O campo Tipo de Conta é obrigatório");
            if (conta.vl_conta == 0)
                throw new ArgumentException("O campo Valor é obrigatório");
        }
        public Model.Entities.tb_conta listarPOrIDModeloReceita(int id)
        {
             Model.Entities.tb_conta IdModelo = db.ListarPorIdModeloReceita(id);

            return IdModelo;

        }

        public Model.Entities.tb_conta listarPOrIDModeloDespesa(int id)
        {
            Model.Entities.tb_conta IdModelo = db.ListarPorIdModeloDespesa(id);

            return IdModelo;

        }
        public void remover(int id)
        
        {
            DataBase.DespesaDatabase Remove = new DataBase.DespesaDatabase();
            Remove.Remover(id);

        }
        public void Alterar(Model.Entities.tb_conta conta)
        {
            Business.DespesaBusiness db = new DespesaBusiness( );
            db.Alterar(conta);
        }

        public List<Model.Entities.tb_conta> ListarReceiaPorOrdem(string ordem)
        {
            List<Model.Entities.tb_conta> lista = new List<Model.Entities.tb_conta>();

            if (ordem == "Valor")
                lista = db.ListarOrdenadoPorValorR();
            if (ordem == "Nome")
                lista = db.ListarOrdenadoPorNomeR();
            if (ordem == "Situação")
                lista = db.ListarOrdenadoPorSituacaoR();

            return lista;
        }

        public List<Model.Entities.tb_conta> ListarDespesaPorOrdem(string ordem)
        {
            List<Model.Entities.tb_conta> lista = new List<Model.Entities.tb_conta>();

            if (ordem == "Valor")
                lista = db.ListarOrdenadoPorValorD();
            if (ordem == "Nome")
                lista = db.ListarOrdenadoPorNomeD();
            if (ordem == "Situação")
                lista = db.ListarOrdenadoPorSituacaoD();

            return lista;
        }

    }
}
