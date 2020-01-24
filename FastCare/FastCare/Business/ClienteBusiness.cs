using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Business
{
    class ClienteBusiness
    {
        public void Inserir(Model.Entities.tb_cliente cliente)
        {
            if (cliente.ds_cel == string.Empty)
                throw new ArgumentException(" o campo Celular è obrigatorio");
            if (cliente.ds_cep == string.Empty)
                throw new ArgumentException(" o campo CEP è obrigatorio");
            if (cliente.ds_cpf == string.Empty)
                throw new ArgumentException(" o campo CPF è obrigatorio");
            if (cliente.ds_email == string.Empty )
                throw new ArgumentException(" o campo Celular è obrigatorio");
            if (cliente.ds_rg == string.Empty)
                throw new ArgumentException(" o campo RG è obrigatorio");
            if (cliente.ds_tel == string.Empty)
                throw new ArgumentException(" o campo TELEFONE è obrigatorio");
            if (cliente.dt_nasc > DateTime.Now)
                throw new ArgumentException(" o campo NASCIMENTO deve ser preenchido corretamente");
            if (cliente.end_cliente == string.Empty)
                throw new ArgumentException(" o campo ENDEREÇO è obrigatorio");
            if (cliente.nm_cliente == string.Empty)
                throw new ArgumentException(" o campo NOME è obrigatorio");
            if (cliente.nu_cliente == string.Empty)
                throw new ArgumentException(" o campo Nº CASA è obrigatorio");
            if (cliente.uf_estado == string.Empty)
                throw new ArgumentException(" o campo ESTADO è obrigatorio");

            DataBase.ClienteDataBase db = new DataBase.ClienteDataBase();
            db.Inserir(cliente);
        }

        public List<Model.Entities.tb_cliente> ListarPorTodos()
        { 
            DataBase.ClienteDataBase db = new DataBase.ClienteDataBase();
            List<Model.Entities.tb_cliente> list = db.ListarTodoss();

            return list;
        }

        public List<Model.Entities.tb_cliente> ListarPorID(int id)
        {
            DataBase.ClienteDataBase db = new DataBase.ClienteDataBase();
            List<Model.Entities.tb_cliente> list = db.ListarPorId(id);

            return list;
        }

        public List<Model.Entities.tb_cliente> ListarPorCpf(string Cpf)
        {
            DataBase.ClienteDataBase db = new DataBase.ClienteDataBase();
            List<Model.Entities.tb_cliente> list = db.ListarPorCpf(Cpf);

            return list;
        }
        public void Remover(int id)
        {
            DataBase.ClienteDataBase db = new DataBase.ClienteDataBase();
            db.Remover(id);
        }

        public void Alterar(Model.Entities.tb_cliente cliente)
        {
            DataBase.ClienteDataBase db = new DataBase.ClienteDataBase();

            if (cliente.ds_cel == string.Empty)
                throw new ArgumentException(" o campo Celular è obrigatorio");
            if (cliente.ds_cep == string.Empty)
                throw new ArgumentException(" o campo CEP è obrigatorio");
            if (cliente.ds_cpf == string.Empty)
                throw new ArgumentException(" o campo CPF è obrigatorio");
            if (cliente.ds_email == string.Empty)
                throw new ArgumentException(" o campo Celular è obrigatorio");
            if (cliente.ds_rg == string.Empty)
                throw new ArgumentException(" o campo RG è obrigatorio");
            if (cliente.ds_tel == string.Empty)
                throw new ArgumentException(" o campo TELEFONE è obrigatorio");
            if (cliente.dt_nasc > DateTime.Now)
                throw new ArgumentException(" o campo NASCIMENTO deve ser preenchido corretamente");
            if (cliente.end_cliente == string.Empty)
                throw new ArgumentException(" o campo ENDEREÇO è obrigatorio");
            if (cliente.nm_cliente == string.Empty)
                throw new ArgumentException(" o campo NOME è obrigatorio");
            if (cliente.nu_cliente == string.Empty)
                throw new ArgumentException(" o campo Nº CASA è obrigatorio");
            if (cliente.uf_estado == string.Empty)
                throw new ArgumentException(" o campo ESTADO è obrigatorio");

            db.Alterar(cliente);
        }
    }    
}
