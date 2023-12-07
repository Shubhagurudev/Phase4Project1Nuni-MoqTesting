using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4pro1NunitAndMoq
{
    public class Subjects
    {
        public int SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }

        public void AcceptData(int sid, string sname, string tname)
        {
            SubjectCode = sid; 
            SubjectName = sname;
            TeacherName = tname;
        }
    }
}
