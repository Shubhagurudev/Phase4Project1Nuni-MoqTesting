using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace SubjectsMoqTesting
{
    [TestFixture]
    public class Subjects
    {

        [Test]
        public void SubjectTest()
        {
            subjects subject = new subjects();
            subject.SubjectCode = 9000;
            subject.SubjectName = "Software";
            subject.TeacherName = "Sindhu";

            subjects subject2 = new subjects();
            subject2.AcceptData(9000, "Software", "Sindhu");

            ClassicAssert.AreEqual(subject.SubjectCode, subject2.SubjectCode);
            ClassicAssert.AreEqual(subject.SubjectName, subject2.SubjectName);
            ClassicAssert.AreEqual(subject.TeacherName, subject2.TeacherName);

            
        }
    }
}
