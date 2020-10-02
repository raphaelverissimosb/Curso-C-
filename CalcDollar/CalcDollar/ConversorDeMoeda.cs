using System;
using System.Collections.Generic;
using System.Text;

namespace CalcDollar
{
    class ConversorDeMoeda
    {

        public static double IOF = 0.06;

        public static double ConversorDollar(double valor , double cotacao) {
            return valor * cotacao;
        }

        public static double ValorIof(double qtdMopnetariaReais) {
            return IOF * qtdMopnetariaReais;
        }

    }
}
