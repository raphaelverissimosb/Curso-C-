using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace ExListCorreto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees are working for you ?");
            int n = int.Parse(Console.ReadLine());

            //Inicializando minha lista 
            List<Employees> list1 = new List<Employees>();
            //Inicializacao de lista okay 

            //inicializacao de itens dentro da lista em suas respecti vas posicoes 

     


            for (int i = 0; i < n ; i++) {
                Console.WriteLine("Cadastro de Numero :" + i);
                
                Console.WriteLine("Por favor informe o o nome da posicao : "+1+"  a ser cadastrado.");
                string nome = Console.ReadLine();
                
                Console.WriteLine("Informe o valor do salario do novo funcionario:");
                double salario = double.Parse(Console.ReadLine());


                Console.WriteLine("Informe o numero de ID a ser atribuido ao fuuncionario:");
                int numero_id = int.Parse(Console.ReadLine());

                list1.Add(new Employees(nome, salario, numero_id));

                if (i > 0) {

                    for (int j = 0; j < i; j++) {
                        if (list1[i].Id == list1[j].Id) {
                            list1[j].Id = 0;
                            list1[j].Name = "0";
                            list1[j].Salary = 0.0;
                            Console.WriteLine("Voce digitou um Id repetido na pos "+j+" redigite as informacoes!");
                        }

                    }
                }
                Console.WriteLine();
            }

            //Pedindo o Id a ser buscado para ser adicionado 
            Console.WriteLine("Por favor informe o Id do funcionario que recebera o aumento :");
            int id_pesquisa = int.Parse(Console.ReadLine());

            Employees emp = list1.Find(x => x.Id == id_pesquisa);

            if (emp != null)
            {
                Console.WriteLine("Por favor informe a porcentagem:");
                double percentagem = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentagem);
            }
            else {

                Console.WriteLine("Id inexistente");
            }


            Console.WriteLine();
            Console.WriteLine("Atualizar listas de Funcionarios");


            foreach (Employees obj in list1) {
                Console.WriteLine(obj);
            }
        }
    }
}
