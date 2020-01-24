using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class PontoDataBase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void Inserir(Model.Entities.tb_car_ponto ponto)
        {
            db.tb_car_ponto.Add(ponto);
            db.SaveChanges();
        }

        public void AdicionarAlmoco(Model.Entities.tb_car_ponto ponto)
        {
            Model.Entities.tb_car_ponto antigo = db.tb_car_ponto.FirstOrDefault(c => c.id_car_ponto == ponto.id_car_ponto);

            antigo.hr_almoco = ponto.hr_almoco;

            db.SaveChanges();
        }

        public Model.Entities.tb_car_ponto ConsultarPontos(int id, DateTime dia)
        {
            Model.Entities.tb_car_ponto ponto = db.tb_car_ponto.FirstOrDefault(c => c.id_funcionario == id && c.dt_dia == dia);
            return ponto;
        }

        public void AdicionarVolta(Model.Entities.tb_car_ponto ponto)
        {
            Model.Entities.tb_car_ponto antigo = db.tb_car_ponto.FirstOrDefault(c => c.id_car_ponto == ponto.id_car_ponto);

            antigo.hr_volta = ponto.hr_volta;

            db.SaveChanges();
        }

        public void AdicionarSaida(Model.Entities.tb_car_ponto ponto)
        {
            Model.Entities.tb_car_ponto antigo = db.tb_car_ponto.FirstOrDefault(c => c.id_car_ponto == ponto.id_car_ponto);

            antigo.hr_saida = ponto.hr_saida;

            db.SaveChanges();
        }

        public void AdicionarHoraExtra(Model.Entities.tb_car_ponto ponto)
        {
            Model.Entities.tb_car_ponto antigo = db.tb_car_ponto.FirstOrDefault(c => c.id_car_ponto == ponto.id_car_ponto);

            antigo.hr_extra = ponto.hr_extra;

            db.SaveChanges();
        }

        public void AdicionarSaidaHoraExtra(Model.Entities.tb_car_ponto ponto)
        {
            Model.Entities.tb_car_ponto antigo = db.tb_car_ponto.FirstOrDefault(c => c.id_car_ponto == ponto.id_car_ponto);

            antigo.hr_saidaextra = ponto.hr_extra;
            antigo.qt_extra = ponto.qt_extra;

            db.SaveChanges();
        }

        public List<Model.Entities.tb_car_ponto> ListarPonto(int id)
        {
            List<Model.Entities.tb_car_ponto> ponto = db.tb_car_ponto.Where(c => c.id_funcionario == id).ToList();
            return ponto;
        }

        public List<Model.Entities.tb_car_ponto> BuscarPontoMes(int id, DateTime inicio, DateTime fim)
        {
            List<Model.Entities.tb_car_ponto> ponto = db.tb_car_ponto.Where(c => c.id_funcionario == id && c.dt_dia >= inicio && c.dt_dia <= fim).ToList();
            return ponto;
        }
    }
}
