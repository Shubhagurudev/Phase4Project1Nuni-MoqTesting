using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TeachersMoqTesting
{
    [TestFixture]
    public class Teachers
    {
        [Test]
        public void TeacherTest()
        {
            teacher t = new teacher();
            t.TeacherId = 7;
            t.TeacherName = "Rashmi";
            t.SubjectId = 7000;

            teacher t1 = new teacher();
            t1.AcceptData(7, "Rashmi", 7000);

            ClassicAssert.AreEqual(t.TeacherId, t1.TeacherId);
            ClassicAssert.AreEqual(t.TeacherName, t1.TeacherName);
            ClassicAssert.AreEqual(t.SubjectId, t1.SubjectId);


            teacher t2 = new teacher();
            t2.TeacherId = 6;
            t2.TeacherName = "Rithu";
            t2.SubjectId = 6000;

            teacher t3 = new teacher();
            t3.AcceptData(6, "Rithu", 6000);

            ClassicAssert.AreEqual(t2.TeacherId, t3.TeacherId);
            ClassicAssert.AreEqual(t2.TeacherName, t3.TeacherName);
            ClassicAssert.AreEqual(t2.SubjectId, t3.SubjectId);
        }

    }
}
