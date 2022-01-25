using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Dependencies
{
    public class LMS
    {
        public List<STUDENT> students = new List<STUDENT>();
        public List<COURSE> availablecourses = new List<COURSE>();
        public List<LECTURER> lecturers = new List<LECTURER>();
        public List<PROFESSOR> professors = new List<PROFESSOR>();  
    }
}
