using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace MoqTesting
{
    [TestFixture]
    public class StudentMoqTesting
    {
        [Test]

        public void StudentTest()
        {
            students s = new students();
            s.StudentRollNo = 105;
            s.StudentName = "Ashika";
            s.ClassId = 5;
            s.SubjectId = 5000;
            s.Gender = "Female";

            students s1 = new students();
            s1.AcceptData(105, "Ashika", 5, 5000, "Female");

            ClassicAssert.AreEqual(s.StudentRollNo, s1.StudentRollNo);
            ClassicAssert.AreEqual(s.StudentName, s1.StudentName);
            ClassicAssert.AreEqual(s.ClassId, s1.ClassId);
            ClassicAssert.AreEqual(s.SubjectId, s1.SubjectId);
            ClassicAssert.AreEqual(s.Gender, s1.Gender);


            students s2 = new students();
            s2.StudentRollNo = 108;
            s2.StudentName = "Yash";
            s2.ClassId = 8;
            s2.SubjectId = 8000;
            s2.Gender = "Male";

            students s3 = new students();
            s3.AcceptData(108, "Yash", 8, 8000, "Male");

            ClassicAssert.AreEqual(s2.StudentRollNo, s3.StudentRollNo);
            ClassicAssert.AreEqual(s2.StudentName, s3.StudentName);
            ClassicAssert.AreEqual(s2.ClassId, s3.ClassId);
            ClassicAssert.AreEqual(s2.SubjectId, s3.SubjectId);
            ClassicAssert.AreEqual(s2.Gender, s3.Gender);
        }

    }
}
