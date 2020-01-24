using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class PresatadorDatabase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void inserir(Model.Entities.tb_prestador p)
        {
            db.tb_prestador.Add(p);
            db.SaveChanges();
        }
        public List<Model.Entities.tb_prestador> ListarPrestTudo()
        {
            List<Model.Entities.tb_prestador> prest = db.tb_prestador.ToList();
            return prest;
        }

        public List<Model.Entities.tb_prestador> ListarPrestTudoInativo()
        {
            List<Model.Entities.tb_prestador> prest = db.tb_prestador.Where(m=> m.bt_ativo == false).ToList();
            return prest;
        }

        public List<Model.Entities.tb_prestador> ListarPrestId(int id)
        {
            List<Model.Entities.tb_prestador> prestId = db.tb_prestador.Where(t => t.id_prestador == id).ToList();
            return prestId;
        }

        public List<Model.Entities.tb_prestador> ListarPrestCpf(string Cpf)
        {
            List<Model.Entities.tb_prestador> prestCpf = db.tb_prestador.Where(t => t.ds_cpf == Cpf).ToList();
            return prestCpf;
        }
        public void Deletar(int id)
        {
            Model.Entities.tb_prestador remove = db.tb_prestador.FirstOrDefault(t => t.id_prestador == id);
            db.tb_prestador.Remove(remove);

            db.SaveChanges();
        }

        public void Alterar(Model.Entities.tb_prestador prest)
        {
            Model.Entities.tb_prestador antigo = db.tb_prestador.FirstOrDefault(t => t.id_prestador == prest.id_prestador);

            antigo.ds_cel = prest.ds_cel;
            antigo.ds_cep = prest.ds_cep;
            antigo.ds_cpf = prest.ds_cpf;
            antigo.ds_email = prest.ds_email;
            antigo.ds_rg = prest.ds_rg;
            antigo.ds_tel = prest.ds_tel;
            antigo.dt_nasc = prest.dt_nasc;
            antigo.end_prestador = prest.end_prestador;
            antigo.nm_cargo = prest.nm_cargo;
            antigo.nm_prestador = prest.nm_prestador;
            antigo.nu_prestador = prest.nu_prestador;

            db.SaveChanges();
        }

        public void AceitarPrestador(int id)
        {
            Model.Entities.tb_prestador antigo = db.tb_prestador.FirstOrDefault(t => t.id_prestador == id);

            antigo.bt_ativo = true;

            db.SaveChanges();
        }

        public void RejeitarPestador(int id)
        {
            Model.Entities.tb_prestador antigo = db.tb_prestador.FirstOrDefault(t => t.id_prestador == id);

            db.tb_prestador.Remove(antigo);

            db.SaveChanges();
        }
    }
}
