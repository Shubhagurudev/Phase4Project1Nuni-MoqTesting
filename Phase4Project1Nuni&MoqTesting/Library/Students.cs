﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4pro1NunitAndMoq
{
    public class Students
    {
        public int StudentRollNo { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public string Gender { get; set; }

        public void AcceptData(int sid, string sname, int cid,int subjectid, string gender)
        {
            StudentRollNo = sid;    
            StudentName = sname;
            ClassId = cid;
            SubjectId = subjectid;
            Gender = gender;
        }
    }
}
