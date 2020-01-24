using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Model.Entities
{
    static class UsuarioLogado
    {
        public static int ID { get; set; }
        public static string usuario { get; set; }
        public static string email { get; set; }
        public static string tipo { get; set; }
        public static DateTime horariologin { get; set; }
        public static string chave { get; set; }
        public static byte[] imagem { get; set; }
    }
}
