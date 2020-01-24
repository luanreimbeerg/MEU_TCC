using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class BusinessPagamento
    {
        public void Inserir(Model.Entities.tb_pagamento pag)
        {

            DataBase.DatabasePagamento db = new DataBase.DatabasePagamento();
            db.InserirPagamento(pag);
        }

        public Model.Entities.tb_pagamento ConsultarFolha(int id)
        {
            DataBase.DatabasePagamento db = new DataBase.DatabasePagamento();
            Model.Entities.tb_pagamento pag = db.BuscarFolha(id);

            return pag;
        }
    }
}
