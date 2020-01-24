using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class ServicosDatabase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();
        public int ServicosRealizados(int id)
        {
            int total = db.tb_servico.Where(m => m.id_prestador == id).Count();

            return total;
        }

        public List<Model.Entities.tb_servico> Estrelas(int id)
        {
            List<Model.Entities.tb_servico> list = db.tb_servico.Where(m => m.id_prestador == id && m.qt_estrela != null).ToList();

            return list;
        }

        public List<Model.Entities.tb_servico> ListarServicos(int id)
        {
            List<Model.Entities.tb_servico> list = db.tb_servico.Where(m => m.id_prestador == id).ToList();

            return list;
        }
    }
}
