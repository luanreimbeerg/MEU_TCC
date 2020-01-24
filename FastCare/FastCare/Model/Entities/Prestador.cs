using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Model.Entities
{
    static class Prestador
    {
        public static int id { get; set; }
        public static string nome { get; set; }
        public static DateTime dt_nasc { get; set; }
        public static string genero { get; set; }
        public static string cpf { get; set; }
        public static string rg { get; set; }
        public static string endereco { get; set; }
        public static string cep { get; set; }
        public static string numero { get; set; }
        public static string uf { get; set; }
        public static string tel { get; set; }
        public static string cel { get; set; }

        public static string email { get; set; }
        public static string setor { get; set; }
    }
}
