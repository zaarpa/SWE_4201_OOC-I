using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Dependencies
{
    public class STUDENT : ENTITY
    {
        
        public string studentSemester; 
        public override string showInfo()
        {
            string temp = this.entityName + "\t\t" + this.studentSemester + "\t\t"; 
           
            return temp;
        }
        public STUDENT(string name)
        {
            this.entityName = name;
        }
    }
}
