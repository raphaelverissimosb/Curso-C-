using System;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde ABCDE FGHIJK abcde";
           
            string s1 = original.ToUpper();//transforma todos os caracteres em maiusculos
            string s2 = original.ToLower();//transforma todos os caracateres em minusculos
            string s3 = original.Trim();// Esta funcao retira todos os espacos em branco ; 
            int n1 = original.IndexOf("bc"); // comandos de busca de caracteres ;
            int n2 = original.LastIndexOf("bc");// comando de busca do ultimo caractere especificado;
            string s4 = original.Substring(3);// separa uma determinada string a partir de um certo ponto 
            string s5 = original.Substring(3, 5);// separa uma string a partir de um determinado ponto, separando a partir de um index e o numero de caracteres a serem capturados

            string s6 = original.Replace('a', 'x');// Replece basicamente substitui um determinado item por outro nao tem a necessidade de serem do mesmo tamanho   

            //Testando campos em branco, IsNUllOrEmpty testa se o conteudo da variavel e nulo ou nao
            bool b1 = String.IsNullOrEmpty(original);
            //Testa e ve se a variavel e nula ou possue espacos em branco
            bool b2 = String.IsNullOrEmpty(original);

            Console.WriteLine("Original ="+ s1 + " - ");
            Console.WriteLine("ToUpper =" + s2 + " - ");
            Console.WriteLine("ToLower = " + s3 + " - ");
            Console.WriteLine("Trim =" + s3 + " - ");
            Console.WriteLine("IndexOf ('bc')" + n1 + " - ");
            Console.WriteLine("Substring(3) = " + s4 +" - ");
            Console.WriteLine("Replace = " + s6 + " - ");

            Console.WriteLine("Is Null or Empty :" + b1);

       


        }
    }
}
