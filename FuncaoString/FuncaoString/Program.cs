using System;

namespace FuncaoString
{
    class Program
    {
        static void Main(string[] args)
        {

            //Transformando minha string to Upper 
            string original = "abcd  ABCD FHHI abc DEFGH";
            Console.WriteLine("Normal:" + original);
            string s1 = original.ToUpper();
            //Apagando espacos em branco 
            string s2 = original.Trim();
            int index = original.IndexOf("bc");

            //imprimindo sem espacos 

            Console.WriteLine("Convertido mausculo : " + s1);
            Console.WriteLine("Convertido sem espacos em branco: "+ s2);
            Console.WriteLine("Encontrada a posicao para b e c: "+ index);


            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine("Esta vazia ?" + b1);

        }

    }
}
