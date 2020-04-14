using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODLab9
{
    public class BankAccount
    {
        public decimal Balance { get; set; }
        public decimal OverDraftLimit { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        
        }
        public void WithDraw(decimal amount)
        {
            decimal availableFunds = Balance + OverDraftLimit;
            if(amount<=availableFunds)//ensuring there is enough money
            Balance -= amount;
        
        }
    }
}
