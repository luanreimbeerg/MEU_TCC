using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class PagamentoBusiness
    {
        public void Inserir(Model.Entities.tb_pagamento pag)
        {

            DataBase.PagamentoDataBase db = new DataBase.PagamentoDataBase();
            db.InserirPagamento(pag);
        }

        public Model.Entities.tb_pagamento ConsultarFolha(int id)
        {
            DataBase.PagamentoDataBase db = new DataBase.PagamentoDataBase();
            Model.Entities.tb_pagamento pag = db.BuscarFolha(id);

            return pag;
        }
    }
}
