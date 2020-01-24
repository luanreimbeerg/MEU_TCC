using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class ServicosBusiness
    {
        DataBase.ServicosDatabase db = new DataBase.ServicosDatabase();

        public double Estrelas (int id)
        {
            List<Model.Entities.tb_servico> list = db.Estrelas(id);
            int estrelas = 0;
            int qtdvalues = list.Count();

            foreach (Model.Entities.tb_servico item in list)
            {
                estrelas += Convert.ToInt32(item.qt_estrela);
            }

            double media = estrelas / qtdvalues;
            double total = Math.Round(media);

            return total;
        }
        public int ServicosRealizados(int id)
        {
            int total = db.ServicosRealizados(id);

            return total;
        }

        public List<Model.Entities.tb_servico> ListarServicos(int id)
        {
            List<Model.Entities.tb_servico> list = db.ListarServicos(id);

            return list;
        }
    }
}
