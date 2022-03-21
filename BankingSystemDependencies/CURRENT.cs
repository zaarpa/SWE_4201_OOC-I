using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDependencies
{
    public class CURRENT:ACCOUNTS
    {
        public string suffix = "300";
        public int minBalance = 500;
        public int minAmount = 0;
        public int withdrawCharge = 0;
        public int maxTransaction = 100000;
        public int lim = int.MaxValue;
        public override int WITHDRAW(int n)
        {
            if(this.accBalance - n < minBalance)
            {
                return 0;
            }
            else
            {
                this.accBalance -= n;
                return 1;
            }
        }
    }
}
