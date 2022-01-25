using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Dependencies
{ 
    public class LECTURER : TEACHER
{
    public double teacherCredit = 1.5;
    public override string showInfo()
    {
        string temp = this.entityName + "\t" + "LECTURER";
       
        return temp;

    }
        public LECTURER (string Name)
        {
            this.entityName = Name;
        }
}
}
