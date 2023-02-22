using System;
using System.Data;
using Enum.Entities;
using Enum.Entities.Enums;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando uma classe pedido.
            Order or = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,

                //Chamando o ENUM e selecionando seus dados
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(or);

        }
    }
}