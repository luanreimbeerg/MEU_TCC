using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class ComprasDatabase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();
        public int ComprasRealizadas(Model.Entities.tb_cliente cli)
        {
            int total = db.tb_compra.Where(m => m.id_cliente == cli.id_cliente).Count();

            return total;
        }

        public int ComprasAvaliadas(Model.Entities.tb_cliente cli)
        {
            int total = db.tb_compra.Where(m => m.id_cliente == cli.id_cliente && m.ds_avaliacao != null).Count();

            return total;
        }
    }
}
