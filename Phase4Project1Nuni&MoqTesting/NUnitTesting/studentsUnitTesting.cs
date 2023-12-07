using p4pro1NunitAndMoq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace StudentsUnitTesting
{
    [TestFixture]
    public class studentsUnitTesting
    {
        [Test]

        public void StudentTest()
        {
            Students s = new Students();
            s.StudentRollNo = 101;
            s.StudentName = "Smruthi";
            s.ClassId = 1;
            s.SubjectId = 1000;
            s.Gender = "Female";

            Students s1 = new Students();
            s1.AcceptData(101, "Smruthi", 1, 1000, "Female");

            ClassicAssert.AreEqual(s.StudentRollNo, s1.StudentRollNo);
            ClassicAssert.AreEqual(s.StudentName, s1.StudentName);
            ClassicAssert.AreEqual(s.ClassId, s1.ClassId);
            ClassicAssert.AreEqual(s.SubjectId, s1.SubjectId);
            ClassicAssert.AreEqual(s.Gender, s1.Gender);


            Students s2 = new Students();
            s2.StudentRollNo = 102;
            s2.StudentName = "Pavitra";
            s2.ClassId = 2;
            s2.SubjectId = 2000;
            s2.Gender = "Female";

            Students s3 = new Students();
            s3.AcceptData(102, "Pavitra", 2, 2000, "Female");

            ClassicAssert.AreEqual(s2.StudentRollNo, s3.StudentRollNo);
            ClassicAssert.AreEqual(s2.StudentName, s3.StudentName);
            ClassicAssert.AreEqual(s2.ClassId, s3.ClassId);
            ClassicAssert.AreEqual(s2.SubjectId, s3.SubjectId);
            ClassicAssert.AreEqual(s2.Gender, s3.Gender);
        }
    }
}
