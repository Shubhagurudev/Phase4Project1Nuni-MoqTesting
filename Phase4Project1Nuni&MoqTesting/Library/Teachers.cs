using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4pro1NunitAndMoq
{
    public class Teachers
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int SubjectId { get; set; }

        public void AcceptData(int tid, string tname, int sid)
        {
            TeacherId = tid;
            TeacherName = tname;
            SubjectId = sid;
        }
    }
}
