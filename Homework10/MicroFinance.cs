using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class MicroFinance : FinanceOperations
    {
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            var totalAmountOfMoney = AmountPerMonth * month;
            var commission = (totalAmountOfMoney * 10) / 100;
            var serviceFee = 4;
            var totalServiceFee = month * serviceFee;

            return totalAmountOfMoney + commission + totalServiceFee;
        } 
        public bool CheckUserHistory()
        {
            return true;
        }
    }
}
