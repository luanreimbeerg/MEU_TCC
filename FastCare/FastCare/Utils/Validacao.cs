using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FastCare.Utils
{
    class Validacao
    {
        public static bool ValidarEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*.com$");

            if (regex.IsMatch(email) == true)
                return true;
            else
                return false;
        }

        public static string ValidarSenha(string senha)
        {
            string forca = "";

            if (senha.Length <= 5)
                forca = "Senha Fraca";

            else if (senha.Length >= 8 && senha.Length <= 9)
                forca = "Senha Média";

            else if (senha.Length >= 10 && senha.Contains("@") || senha.Contains("!") || senha.Contains("#") || senha.Contains("$"))
                forca = "Senha Forte";

            return forca;
        } 

        public static bool ValidarRequerido(string valor)
        {
            if (!string.IsNullOrEmpty(valor))
                return true;
            else
                return false;
        }
        public static bool ValidarCnpj(string cnpj)
        {
            Regex regex = new Regex(@"^[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}$");

            if (regex.IsMatch(cnpj) == true)
                return true;
            else
                return false;
        }
        public static bool ValidarCpf(string cpf)
        {
            Regex regex = new Regex(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$");

            if (regex.IsMatch(cpf) == true)
                return true;
            else
                return false;
        }
        public static bool ValidarRg(string rg)
        {
            Regex regex = new Regex(@"^[0-9]{2}\.[0-9]{3}\.[0-9]{3}-\w$");

            if (regex.IsMatch(rg) == true)
                return true;
            else
                return false;
        }

        public static bool ValidarCep(string cep)
        {
            Regex regex = new Regex(@"^[0-9]{5}-[\d]{3}$");

            if (regex.IsMatch(cep) == true)
                return true;
            else
                return false;
        }
        public static bool ValidarCelOuTel(string celular)
        {
            Regex regex = new Regex(@"^(?:(?:\+|00)?(55)\s?)?(?:\(?([1-9][0-9])\)?\s?)?(?:((?:9\d|[2-9])\d{3})\-?(\d{4}))$");

            if (regex.IsMatch(celular) == true)
                return true;
            else
                return false;
        }
        public static bool ValidarDt(DateTime nasc)
        {
            DateTime dataAgora = DateTime.Now;
            DateTime dataNascimento = new DateTime(1978, 11, 7);
            int idade = 0;

            if (nasc.Month >= dataAgora.Month && nasc.Day >= dataAgora.Day)
            {
                idade = dataAgora.Year - nasc.Year;
            }
            else
                idade = dataAgora.Year - nasc.Year - 1; 



            if (idade >= 16)
                return true;
            else
                return false;
        }
    }
} 
