namespace TestSchool
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentConstructorTestName()
        {
            string name = "Albena Stoeva";
            int id = 20000;
            Student student = new Student(name, id);
            Assert.AreEqual(student.Name, "Albena Stoeva");
        }

        [TestMethod]
        public void StudentConstructorTestId()
        {
            string name = "Albena Stoeva";
            int id = 20000;
            Student student = new Student(name, id);
            Assert.AreEqual(student.Id, 20000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            int id = 20000;
            Student student = new Student(name, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            int id = 20000;
            Student student = new Student(name, id);
        }

        [TestMethod]
        public void IdTestStartValue()
        {
            string name = "Albena Stoeva";
            int id = 10000;
            Student student = new Student(name, id);
            Assert.IsTrue(id >= 10000 && id <= 99999);
        }

        [TestMethod]
        public void IdTestEndValue()
        {
            string name = "Albena Stoeva";
            int id = 99999;
            Student student = new Student(name, id);
            Assert.IsTrue(id >= 10000 && id <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IdTestStartValueMinusOne()
        {
            string name = "Albena Stoeva";
            int id = 9999;
            Student student = new Student(name, id);
            Assert.IsTrue(id >= 10000 && id <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IdTestEndValuePlusOne()
        {
            string name = "Albena Stoeva";
            int id = 100000;
            Student student = new Student(name, id);
            Assert.IsTrue(id >= 10000 && id <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IDTestZero()
        {
            string name = "Albena Stoeva";
            int id = 0;
            Student student = new Student(name, id);
            Assert.IsTrue(id >= 10000 && id <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IdTestIntMaxValue()
        {
            string name = "Albena Stoeva";
            int id = int.MaxValue;
            Student student = new Student(name, id);
            Assert.IsTrue(id >= 10000 && id <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IdTestNegativeValue()
        {
            string name = "Albena Stoeva";
            int id = -10000;
            Student student = new Student(name, id);
            Assert.IsTrue(id >= 10000 && id <= 99999);
        }
    }
}