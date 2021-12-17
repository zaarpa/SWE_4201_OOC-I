using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEEMANAGEMNET
{
    internal class ADMIN
    {
        public int adminid;
        public string adminname;
        public string admindesignation;
        public int adminsalary;

        public string getAdmininfo()
        {
            string admininfo = adminid.ToString() + " " + adminname + " " + admindesignation + " " + adminsalary.ToString();
            return admininfo;
        }
    }
}
