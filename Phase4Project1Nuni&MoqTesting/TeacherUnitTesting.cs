using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p4pro1NunitAndMoq;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace NunitToDoUnitTesting
{
    [TestFixture]
    public class TeacherUnitTesting
    {
        [Test]
        public void TeacherTest()
        {
            Teachers t = new Teachers();
            t.TeacherId = 1;
            t.TeacherName = "Sangeetha";
            t.SubjectId = 1000;

            Teachers t1 = new Teachers();
            t1.AcceptData(1, "Sangeetha", 1000);

            ClassicAssert.AreEqual(t.TeacherId, t1.TeacherId);
            ClassicAssert.AreEqual(t.TeacherName, t1.TeacherName);
            ClassicAssert.AreEqual(t.SubjectId, t1.SubjectId);


            Teachers t2 = new Teachers();
            t2.TeacherId = 2;
            t2.TeacherName = "Tejaswini";
            t2.SubjectId = 2000;

            Teachers t3 = new Teachers();
            t3.AcceptData(2, "Tejaswini", 2000);

            ClassicAssert.AreEqual(t2.TeacherId, t3.TeacherId);
            ClassicAssert.AreEqual(t2.TeacherName, t3.TeacherName);
            ClassicAssert.AreEqual(t2.SubjectId, t3.SubjectId);
        }
    }
}

