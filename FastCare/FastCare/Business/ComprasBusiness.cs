using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class ComprasBusiness
    {

        DataBase.ComprasDatabase db = new DataBase.ComprasDatabase();

        public int ComprasRealizadas(Model.Entities.tb_cliente cli)

        {
            int total = db.ComprasRealizadas(cli);

            return total;
        }

        public int ComprasAvaliadas(Model.Entities.tb_cliente cli)
        {

            int total = db.ComprasAvaliadas(cli);

            return total;
        }
    }
}
