using System;
using System.Collections.Generic;
using Exercicio_10.Entities;
namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Func = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Employee {i} data:");
                Console.Write("Outsourced (y/n)? ");
                char op = char.Parse(Console.ReadLine());
                if (op == 'y')
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hour = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePer = double.Parse(Console.ReadLine());
                    double valuePer = double.Parse(Console.ReadLine());

                }

            }

        }
        
    }
}
/*Fazer um programa para ler os dados de N funcionários (N
fornecido pelo usuário) e armazená-los em uma lista. Depois
de ler todos os dados, mostrar nome e pagamento de cada
funcionário na mesma ordem em que foram digitados.
Construa o programa conforme projeto ao lado. Veja
exemplo na próxima página.*/