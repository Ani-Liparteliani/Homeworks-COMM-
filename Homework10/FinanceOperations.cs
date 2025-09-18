using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public interface FinanceOperations
    {
        double CalculateLoanPercent(int month, double AmountPerMonth);
        bool CheckUserHistory();
    }
}
