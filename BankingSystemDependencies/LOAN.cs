using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDependencies
{
    public class LOAN:ACCOUNTS
    {
        public string suffix = "400";
        public int minBalance = 0;
        public int minAmount = 0;
        public int withdrawCharge = 0;
        public int maxTransaction = int.MaxValue;
        public double dueAmount = 0;
        public int lim = int.MaxValue;
        public override int DEPOSIT(int n)
        {
            if(n<=this.dueAmount)
            {
                this.dueAmount -= n;
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        public override int WITHDRAW(int n)
        {
            return 0;
        }
        public void Loan(int n)
        {
            this.dueAmount = n + n * 0.9;
        }
    }
}
