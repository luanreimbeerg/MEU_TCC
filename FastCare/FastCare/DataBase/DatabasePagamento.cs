using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class DatabasePagamento
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void InserirPagamento(Model.Entities.tb_pagamento pag)
        {
            db.tb_pagamento.Add(pag);
            db.SaveChanges();

        }

        public Model.Entities.tb_pagamento BuscarFolha(int id)
        {
            Model.Entities.tb_pagamento pag = db.tb_pagamento.FirstOrDefault(p => p.id_funcionario == id);
            return pag;

        }


    }
}
