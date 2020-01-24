using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class PontoBusiness
    {
        DataBase.PontoDataBase db = new DataBase.PontoDataBase();

        public Model.Entities.tb_car_ponto AdicionarPonto (Model.Entities.tb_car_ponto ponto)
        {
            int id = Convert.ToInt32(ponto.id_funcionario);
            DateTime dia = DateTime.Now.Date;

            Model.Entities.tb_car_ponto existente = db.ConsultarPontos(id, dia);
            if(existente != null) 
                ponto.id_car_ponto = existente.id_car_ponto;

            if (existente == null)
            {
                ponto.hr_almoco = null;
                ponto.hr_volta = null;
                ponto.hr_saida = null;
                ponto.hr_extra = null;
                ponto.hr_saidaextra = null;
                db.Inserir(ponto);
            }
                
            else if (existente.hr_entrada != null && existente.hr_almoco == null)
                db.AdicionarAlmoco(ponto);

            else if (existente.hr_almoco != null && existente.hr_volta == null)
                db.AdicionarVolta(ponto);

            else if (existente.hr_volta != null && existente.hr_saida == null)
                db.AdicionarSaida(ponto);

            else if (existente.hr_saida != null && existente.hr_extra == null)
                db.AdicionarHoraExtra(ponto);

            else if (existente.hr_extra != null && existente.hr_saidaextra == null)
            {
                TimeSpan horas = DateTime.Now.TimeOfDay - existente.hr_extra.Value;

                if (horas.TotalMinutes >= 59)
                    ponto.qt_extra = horas.Hours + 1;
                else
                    ponto.qt_extra = horas.Hours;

                db.AdicionarSaidaHoraExtra(ponto);
            }

            existente = db.ConsultarPontos(id, dia);

            return existente;
        }
        public List<Model.Entities.tb_car_ponto> ListarPonto(int id)
        {
            List<Model.Entities.tb_car_ponto> ponto = db.ListarPonto(id);
            return ponto;
        }

        public int BuscarHorasMes(int id, DateTime mes)
        {
            DateTime inicio = new DateTime(mes.Year, mes.Month - 1, 1);
            DateTime fim = new DateTime(mes.Year, mes.Month - 1, DataFinalMes(mes));

            List<Model.Entities.tb_car_ponto> ponto = db.BuscarPontoMes(id, inicio, fim);
            int horas = 0;

            foreach (Model.Entities.tb_car_ponto item in ponto)
            {
                horas += Convert.ToInt32(item.qt_extra);
            }

            return horas;
        }

        private int DataFinalMes(DateTime mes)
        {
            int dias = 0;
            int numeromes = mes.Month - 1;

            if (numeromes == 1)
                dias = 31;
            if (numeromes == 2)
                dias = 28;
            if (numeromes == 3)
                dias = 31;
            if (numeromes == 4)
                dias = 30;
            if (numeromes == 5)
                dias = 31;
            if (numeromes == 6)
                dias = 30;
            if (numeromes == 7)
                dias = 31;
            if (numeromes == 8)
                dias = 31;
            if (numeromes == 9)
                dias = 30;
            if (numeromes == 10)
                dias = 31;
            if (numeromes == 11)
                dias = 30;
            if (numeromes == 12)
                dias = 31;

            return dias;
        }
    }
}
