using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10 
{
    internal class Bank : FinanceOperations
    {
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            var totalAmountOfMoney = AmountPerMonth * month;
            var loanInterest = (totalAmountOfMoney * 5) / 100;
            return totalAmountOfMoney + loanInterest;
        }
        public bool CheckUserHistory()
        {
            bool randomBool = new Random().Next(2) == 0;
            return randomBool;
            
        }
    }
}
