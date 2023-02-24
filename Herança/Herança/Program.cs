using Heranca.Entities;
using System;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount accB = new BusinessAccount(8010, "Bob", 100.0, 500.0);

            //Não é possível acessar e alterar o valor sem ser pela classe ou Subclasse;
            //Pois no Balance o metodo set foi inserido como Protected!
            accB.Balance = 200.00;
        }
    }
}