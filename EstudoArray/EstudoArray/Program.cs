using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace EstudoArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many employees will be registred? ");
            int employess = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < employess; i++)
            {
                Console.WriteLine($"Employees #{i + 1}");

                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = (Console.ReadLine());

                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee ID that will have salary increase: ");
            int procurarId = int.Parse((Console.ReadLine()));

            //Função lambda para procurar o Id digitado pelo usuário
            Funcionario func = list.Find(x => x.Id == procurarId);

            //Se o Id digitado for DIFERENTE de nulo, continua a operação para inserir o aumento de salario
            if (func != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine());
                func.aumentarSalario(percent);
            }
            else
            {
                Console.WriteLine("Funcionário não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Funcionário atualizado: ");
            foreach (Funcionario f in list)
            {
                Console.Write(f);
            }
        }
    }
}