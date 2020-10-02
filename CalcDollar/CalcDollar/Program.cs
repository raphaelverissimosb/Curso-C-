using System;
using System.Globalization;
using System.Threading.Tasks.Sources;

namespace CalcDollar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual e a cotacao do Dollar ?");
            double cotacaoDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Quantidade de dollares a serem trocados ?");
            double qtdReais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double valorConvertido = ConversorDeMoeda.ConversorDollar(qtdReais, cotacaoDollar);
            Console.WriteLine("O valor da conversao de  R$: "  + qtdReais +" cotado a " + cotacaoDollar + " e de  U$ :" + valorConvertido.ToString(CultureInfo.CurrentCulture));
            Console.WriteLine();
            double valorImpIOF = ConversorDeMoeda.ValorIof(qtdReais);
            Console.WriteLine("Valor em IOF R$:" + valorImpIOF);

        }

    }
}
