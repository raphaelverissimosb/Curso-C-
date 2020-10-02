using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Raphael");
            list.Add("BOB");
            list.Insert(2, "Marco");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count :" + list.Count);

            string s1 = list.Find( x => x[0]  == 'R');

            string s2 = list.FindLast(x => x[0] == 'M');

            Console.WriteLine("Primeiro com R :" + s1);
            Console.WriteLine("Ultima ocorrencia com M :" + s2);

            int pos1 = list.FindIndex(x => x[0] == 'R');
            Console.WriteLine("Primeira posicao comecando cm 'A'" + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posicao comecando com 'A'");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("*****************************************");

            foreach (string obj in list2) {
                
                Console.WriteLine(obj);
                
            }

            list.RemoveAt(3);
            Console.WriteLine("*****************************************");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }


            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("*****************************************");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }

        /*
        static bool Test(string s)
        {
            return s[0] == 'R';
        }*/
    }

}
