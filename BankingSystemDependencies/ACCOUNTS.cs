using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemDependencies
{
    public class ACCOUNTS
    {
        public string accOwner;
        public string accNo;
        public int accBalance;
        public string contact;
        public List<string> transactions = new List<string>();
        public virtual int DEPOSIT(int n)
        {
            accBalance += n;
            return 1;
        }
        public virtual int WITHDRAW(int n)
        {
            accBalance -= n;
            return 1;
        }
        public string GETINFO()
        {
            string info = this.accOwner + "\t" + this.accBalance;
            return info;
        }
        
    }
    
}
