using System;
using System.Globalization;

namespace Vetores1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n ; i++) {
                Console.WriteLine("Digite um numero para a posicao ["+i+"]");
                vect[i] = double.Parse(Console.ReadLine());

            }

            double sum = 0.0;

            for (int i = 0; ;){
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("A altura media e igual a " + avg);



        }
    }
}
