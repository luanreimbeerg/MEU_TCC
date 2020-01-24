using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class FinanceirosBusiness
    {
        DataBase.FinanceiroDataBase db = new DataBase.FinanceiroDataBase();

        public List<Model.Entities.vw_fluxo_caixa> ListarPorFluxo(DateTime datainicio, DateTime datafim)
        {
            List<Model.Entities.vw_fluxo_caixa> fluxo = db.ListaPorData(datainicio, datafim);
            return fluxo;
        }

        //public void Inserir(Model.Entities.tb_financeiro Fin)
        //{
        //    //if (cliente.ds_cel == string.Empty)
        //    //throw new ArgumentException(" o campo Celular è obrigatorio");
        //    // if (cliente.ds_cep == string.Empty)
        //    //  throw new ArgumentException(" o campo CEP è obrigatorio");
        //    // if (cliente.ds_cpf == string.Empty)
        //    // throw new ArgumentException(" o campo CPF è obrigatorio");
        //    // if (cliente.ds_email == string.Empty)
        //    // throw new ArgumentException(" o campo Celular è obrigatorio");
        //    //  if (cliente.ds_rg == string.Empty)
        //    //throw new ArgumentException(" o campo RG è obrigatorio");
        //    // if (cliente.ds_tel == string.Empty)
        //    // throw new ArgumentException(" o campo TELEFONE è obrigatorio");
        //    // if (cliente.dt_nasc > DateTime.Now)
        //    // throw new ArgumentException(" o campo NASCIMENTO deve ser preenchido corretamente");
        //    //  if (cliente.end_cliente == string.Empty)
        //    // throw new ArgumentException(" o campo ENDEREÇO è obrigatorio");
        //    //  if (cliente.nm_cliente == string.Empty)
        //    // throw new ArgumentException(" o campo NOME è obrigatorio");
        //    // if (cliente.nu_cliente == string.Empty)
        //    // throw new ArgumentException(" o campo Nº CASA è obrigatorio");
        //    // if (cliente.UF_estado == string.Empty)
        //    //  throw new ArgumentException(" o campo ESTADO è obrigatorio");

        //    DataBase.FinanceiroDataBase db = new DataBase.FinanceiroDataBase();
        //    db.Inserir(Fin);
        //}

        //public List<Model.Entities.tb_financeiro> ListarPorTodos()
        //{
        //    DataBase.FinanceiroDataBase db = new DataBase.FinanceiroDataBase();
        //    List<Model.Entities.tb_financeiro> list = db.ListarTodos();

        //    return list;
        //}

        //public List<Model.Entities.tb_financeiro> ListarPorID(int id)
        //{
        //    DataBase.FinanceiroDataBase db = new DataBase.FinanceiroDataBase();
        //    List<Model.Entities.tb_financeiro> list = db.ListarPorId(id);

        //    return list;
        //}

        //public List<Model.Entities.tb_financeiro> ListarPorLucros(string lucros)
        //{
        //    DataBase.FinanceiroDataBase db = new DataBase.FinanceiroDataBase();
        //    List<Model.Entities.tb_financeiro> list = db.ListarPorLucros(lucros);

        //    return list;
        //}
        //public void Remover(int id)
        //{
        //    DataBase.FinanceiroDataBase db = new DataBase.FinanceiroDataBase();
        //    db.Remover(id);
        //}

        //public void Alterar(Model.Entities.tb_financeiro fina)
        //{
        //    DataBase.FinanceiroDataBase db = new DataBase.FinanceiroDataBase();
        //    db.Alterar(fina);
        //}
    }
}
