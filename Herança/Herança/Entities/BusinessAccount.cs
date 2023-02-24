using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class BusinessAccount : Account
    {
        public double loanLimit { get; set; }

        public BusinessAccount() { }

        //Ao inves de repetir todos os atributos da classe, você chama o construtor.
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            loanLimit = loanLimit;
        }
        public void loan(double amount)
        {
            if (amount <= loanLimit)
            {
                Balance += amount;
            }
        }
    }
}
