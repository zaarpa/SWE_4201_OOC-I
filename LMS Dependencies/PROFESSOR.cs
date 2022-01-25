using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Dependencies
{
    public class PROFESSOR : TEACHER
    {
        public double teacherCredit = 3;
        public override string showInfo()
        {
            string temp = this.entityName + "\t" + "PROFESSOR";
            
            return temp; 
        }
        public PROFESSOR (string name)
        {
            this.entityName = name;
        }
    }
}
