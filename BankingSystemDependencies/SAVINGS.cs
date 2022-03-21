using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDependencies
{
    public class SAVINGS:ACCOUNTS
    {
        public string suffix = "314";
        public int minAmount = 50000;
        public int minBalance = 0;
        public int withdrawCharge = 0;
        public int maxTranscation = int.MaxValue;
        public int lim = int.MaxValue;
        public override int DEPOSIT(int n)
        {
            if(this.accBalance == 0 && n>=this.minAmount)
            {
                this.accBalance += n;
            }
            else if(this.accBalance != 0)
            {
                this.accBalance += n;
            }
            else
            {
                return 0;
            }
            return 1;
        }
        public override int WITHDRAW(int n)
        {
            this.lim--;
            if(this.lim >= 0)
            {
                this.accBalance -= n;
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
