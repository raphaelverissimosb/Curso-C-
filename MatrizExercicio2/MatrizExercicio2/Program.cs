using System;

namespace MatrizExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero de linhas:");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numeor de colunnas:");
            int coluna = int.Parse(Console.ReadLine());

            int[,] mat = new int[linha, coluna];

            for (int i = 0; i < linha ;i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluna;j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Informe um numero a ser pesquisado:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++) {
                for (int j = 0; j < coluna; j++) {
                    if (mat[i, j] == numero) {

                        if (j > 0) {
                            Console.WriteLine("Left:" + mat[i,j-1]);
                        }


                        if (i > 0) {
                            Console.WriteLine("Up"+ mat[i-1,j]);
                        }

                        if (j < coluna - 1) {
                            Console.WriteLine("Right:" + mat[i, j+1]) ;
                        }

                        if (i < linha - 1) {
                            Console.WriteLine("Bottom:" + mat[i + 1, j]);
                        }
                                            
                    }
                }
            }
            
        }
    }
}
