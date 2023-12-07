using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p4pro1NunitAndMoq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace SubjectsUnitTesting
{
    [TestFixture]
    public class SubjectUnitTesting
    {  
        [Test]
            public void SubjectTest()
            {
                Subjects subject = new Subjects();
                subject.SubjectCode = 1000;
                subject.SubjectName = "Games";
                subject.TeacherName = "Sangeetha";

                Subjects subject2 = new Subjects();
                subject2.AcceptData(1000, "Games", "Sangeetha");

                ClassicAssert.AreEqual(subject.SubjectCode, subject2.SubjectCode);
                ClassicAssert.AreEqual(subject.SubjectName, subject2.SubjectName);
                ClassicAssert.AreEqual(subject.TeacherName, subject2.TeacherName);

            Subjects subject3 = new Subjects();
            subject3.SubjectCode = 2000;
            subject3.SubjectName = "DotNet";
            subject3.TeacherName = "Tejaswini";

            Subjects subject4 = new Subjects();
            subject4.AcceptData(2000, "DotNet", "Tejaswini");

            ClassicAssert.AreEqual(subject3.SubjectCode, subject4.SubjectCode);
            ClassicAssert.AreEqual(subject3.SubjectName, subject4.SubjectName);
            ClassicAssert.AreEqual(subject3.TeacherName, subject4.TeacherName);
        }
    }
}


