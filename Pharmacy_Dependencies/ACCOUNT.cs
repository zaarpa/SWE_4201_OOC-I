using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Dependencies
{
    public class ACCOUNT 
    {
        public double accountBalance = 1000;
        public void addBalance(double n)
        {
            accountBalance += n;
        }
        public void subBalance(double n)
        {
            accountBalance -= n;
        }
        public double getBalance()
        {
            return accountBalance; 
        }
    }
} 
