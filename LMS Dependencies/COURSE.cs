using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Dependencies
{
    public class COURSE
    {
        public string courseTitle;
        public string courseType;
        public string courseTeacher;
        public string courseSemester;
        public string courseCode;
        public double courseCredit;

        public COURSE(string title, string type, string teacher, string semester, string code, double credit) 
        {
            this.courseTitle = title;
            this.courseType = type;
            this.courseTeacher = teacher;
            this.courseSemester = semester;
            this.courseCode = code; 
            this.courseCredit = credit;
        }

    }
}
