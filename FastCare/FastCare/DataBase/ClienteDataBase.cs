using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class ClienteDataBase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void Inserir(Model.Entities.tb_cliente cliente)
        {
            db.tb_cliente.Add(cliente);
            db.SaveChanges();
        }

       public List<Model.Entities.tb_cliente> ListarTodoss()
       {
            List<Model.Entities.tb_cliente> clie = db.tb_cliente.ToList();
            return clie;
       }

       public List<Model.Entities.tb_cliente> ListarPorId(int id)
       {
            List<Model.Entities.tb_cliente> clieId = db.tb_cliente.Where(t => t.id_cliente == id).ToList();
            return clieId;
       }

       public List<Model.Entities.tb_cliente> ListarPorCpf(string Cpf)
       {
            List<Model.Entities.tb_cliente> clieCpf = db.tb_cliente.Where(t => t.ds_cpf == Cpf).ToList();
            return clieCpf;
       }
        public void Remover(int id)
        {
            Model.Entities.tb_cliente remove = db.tb_cliente.FirstOrDefault(t => t.id_cliente == id);
            db.tb_cliente.Remove(remove);

            db.SaveChanges();
        }
        public void Alterar(Model.Entities.tb_cliente cli)
        {
            Model.Entities.tb_cliente antigo = db.tb_cliente.FirstOrDefault(c => c.id_cliente == cli.id_cliente);

            antigo.ds_cel = cli.ds_cel;
            antigo.ds_cep = cli.ds_cep;
            antigo.ds_cpf = cli.ds_cpf;
            antigo.ds_email = cli.ds_email;
            antigo.ds_rg = cli.ds_rg;
            antigo.ds_tel = cli.ds_tel;
            antigo.dt_nasc = cli.dt_nasc;
            antigo.end_cliente = cli.end_cliente;
            antigo.nm_cliente = cli.nm_cliente;
            antigo.nu_cliente = cli.nu_cliente;
            antigo.uf_estado = cli.uf_estado;

            db.SaveChanges();
        }
    }
}
