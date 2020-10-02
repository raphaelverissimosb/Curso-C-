using System;

namespace Ex1Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o numero de linha para sua matriz:");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de colunas para a sua matriz:");
            int coluna = int.Parse(Console.ReadLine());

            int[,] mat = new int[linha, coluna];


            // Utilizando um split para separar os elementos do vetor
            for (int i = 0; i < linha ; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++) {

                    mat[i, j] = int.Parse(values[j]);

                }
                
            }


            //Percorrendo a matraz e achando a diagonal principal
            for (int i = 0; i < linha; i++) {

                Console.WriteLine("Main diagonal:"+"["+i+"]" + "["+i+"]");
                Console.WriteLine(mat[i,i]);

            }
            Console.WriteLine();

            //Percorrendo a matriz inteira para encontrar numeros negativos 

            int count = 0;

            for (int i = 0; i < linha; i++) {
                for (int j = 0; j < coluna ; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }


            Console.WriteLine("A matriz possui " +count+ " numeros negativos");

        }
    }
}
