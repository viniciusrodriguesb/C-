using System;
using ExerciciosEnum.Entities;
using ExerciciosEnum.Entities.Enums;

namespace ExerciciosEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter work data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Level (Junior/Midlevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            //Instanciando um Worker e inserindo como parametro as variaveis criadas.
            Worker worker = new Worker(deptName, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            //Repetição de acordo com o que usuario digitar acima
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Data: (DD/MM/YYYY) ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.WriteLine("Duration: hours");
                int hours = int.Parse(Console.ReadLine());

                //Instanciação do HourContract, inserindo como parametro as variaveis criadas.
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }

            Console.WriteLine("Enter month and year to calculate income: ");
            string monthAndYear = Console.ReadLine();

            //Metodo utilizado para recortar toda a string descrita acima e pegar apenas,
            //Dos dados 0 até o 2.
            int month = int.Parse(monthAndYear.Substring(0, 2));

            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);

            Console.WriteLine("Department: " + worker.Department.Name);

            Console.WriteLine("Income for" + monthAndYear + ":" + worker.Income(year, month));
        }
    }
}