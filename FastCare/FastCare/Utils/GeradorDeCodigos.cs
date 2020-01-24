using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Utils
{
    class GeradorDeCodigos
    {
        public string GerarCodigo()
        {
            string codigo = "";
            string ultimo = "";

            while(codigo.Length != 9)
            {

                if (codigo.Length == 4)
                    codigo = codigo + "-";

                int numero = NumeroAleatorio();
                string valor = TrocaDeValores(numero);

                if(valor == ultimo)
                {
                    while(ultimo == valor)
                    {
                        numero = NumeroAleatorio();
                        valor = TrocaDeValores(numero);
                    }
                }

                codigo = codigo + valor;
                ultimo = valor;
            }

            return codigo;
        }

        private int NumeroAleatorio()
        {
            Random aleatorio = new Random();
            int a = aleatorio.Next(1, 37);
            return a;
        }

        private string TrocaDeValores(int numero)
        {
            string valor = "";
            if (numero == 1)
                valor = "A";
            if (numero == 2)
                valor = "B";
            if (numero == 3)
                valor = "C";
            if (numero == 4)
                valor = "D";
            if (numero == 5)
                valor = "E";
            if (numero == 6)
                valor = "F";
            if (numero == 7)
                valor = "G";
            if (numero == 8)
                valor = "H";
            if (numero == 9)
                valor = "I";
            if (numero == 10)
                valor = "J";
            if (numero == 11)
                valor = "K";
            if (numero == 12)
                valor = "L";
            if (numero == 13)
                valor = "M";
            if (numero == 14)
                valor = "N";
            if (numero == 15)
                valor = "O";
            if (numero == 16)
                valor = "P";
            if (numero == 17)
                valor = "Q";
            if (numero == 18)
                valor = "R";
            if (numero == 19)
                valor = "S";
            if (numero == 20)
                valor = "T";
            if (numero == 22)
                valor = "U";
            if (numero == 2)
                valor = "V";
            if (numero == 23)
                valor = "W";
            if (numero == 24)
                valor = "X";
            if (numero == 25)
                valor = "Y";
            if (numero == 26)
                valor = "Z";
            if (numero == 27)
                valor = "1";
            if (numero == 28)
                valor = "2";
            if (numero == 29)
                valor = "3";
            if (numero == 30)
                valor = "4";
            if (numero == 31)
                valor = "5";
            if (numero == 32)
                valor = "6";
            if (numero == 33)
                valor = "7";
            if (numero == 34)
                valor = "8";
            if (numero == 35)
                valor = "9";

            return valor;
        }


    }
}
