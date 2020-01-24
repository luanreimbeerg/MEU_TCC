using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class FinanceiroDataBase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public List<Model.Entities.vw_fluxo_caixa> ListaPorData(DateTime datainicio, DateTime datafim)
        {
            List<Model.Entities.vw_fluxo_caixa> fluxo = db.vw_fluxo_caixa.Where(t => t.dt_pagamento >= datainicio && t.dt_pagamento <= datafim).ToList();
            return fluxo;
        }
    }
}
