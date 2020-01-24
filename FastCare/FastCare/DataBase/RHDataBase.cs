using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.DataBase
{
    class RHDataBase
    {
        Model.Entities.Fast_CareEntities db = new Model.Entities.Fast_CareEntities();

        public void Inserir(Model.Entities.tb_funcionario rh)
        {
            db.tb_funcionario.Add(rh);
            db.SaveChanges();
        }
    
       public List<Model.Entities.tb_funcionario> ListarTodos()
       {
            List<Model.Entities.tb_funcionario> emp = db.tb_funcionario.ToList();
            return emp;
       }

       public List<Model.Entities.tb_funcionario> ListarPorId(int id)
       {
            List<Model.Entities.tb_funcionario> empId = db.tb_funcionario.Where(t => t.id_funcionario == id).ToList();
            return empId;
       }

        public List<Model.Entities.tb_funcionario> ListarPorCpf(string Cpf)
       {
            List<Model.Entities.tb_funcionario> empCpf = db.tb_funcionario.Where(t => t.ds_cpf == Cpf).ToList();
            return empCpf;
       }
        public void Remover(int id)
        {
            Model.Entities.tb_funcionario remove = db.tb_funcionario.FirstOrDefault(t => t.id_funcionario == id);
            db.tb_funcionario.Remove(remove);

            db.SaveChanges();
        }

        public void Alterar(Model.Entities.tb_funcionario emp)
        {
            Model.Entities.tb_funcionario antigo = db.tb_funcionario.FirstOrDefault(t => t.id_funcionario == emp.id_funcionario);

            antigo.bl_va = emp.bl_va;
            antigo.bl_vt = emp.bl_vt;
            antigo.est_civil = emp.est_civil;
            antigo.ds_cel = emp.ds_cel;
            antigo.ds_cep = emp.ds_cep;
            antigo.ds_cpf = emp.ds_cpf;
            antigo.ds_email = emp.ds_email;
            antigo.ds_rg = emp.ds_rg;
            antigo.ds_setor = emp.ds_setor;
            antigo.ds_genero = emp.ds_genero;
            antigo.ds_tel = emp.ds_tel;
            antigo.dt_contratacao = emp.dt_contratacao;
            antigo.dt_nasc = emp.dt_nasc;
            antigo.end_funcionario = emp.end_funcionario;
            antigo.nm_cargo = emp.nm_cargo;
            antigo.nm_funcionario = emp.nm_funcionario;
            antigo.nu_funcionario = emp.nu_funcionario;
            antigo.qt_salario = emp.qt_salario;
            antigo.uf_estado = emp.uf_estado;
            antigo.vl_va = emp.vl_va;
            antigo.vl_vt = emp.vl_vt;

            db.SaveChanges();
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorId()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.id_funcionario).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorNome()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.nm_funcionario).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorVa()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.bl_va).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorvt()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.bl_vt).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorgenero()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.ds_genero).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorSetor()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.ds_setor).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorContratacao()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.dt_contratacao).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorNascimento()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.dt_nasc).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorEstadoCivil()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.est_civil).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorCargo()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.nm_cargo).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorSalario()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.qt_salario).ToList();
            return f;
        }
        public List<Model.Entities.tb_funcionario> ListarOrdenadoPorEstado()
        {
            List<Model.Entities.tb_funcionario> f = db.tb_funcionario.OrderBy(t => t.uf_estado).ToList();
            return f;
        }
        public Model.Entities.tb_funcionario ListarFuncionario(int id)
        {
            Model.Entities.tb_funcionario empId = db.tb_funcionario.FirstOrDefault(t => t.id_funcionario == id);
            return empId;
        }

    }
}
