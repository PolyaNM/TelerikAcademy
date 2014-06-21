namespace TestSchool
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CourseConstructorTestName()
        {
            string name = "Javascript";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, "Javascript");
        }

        [TestMethod]
        public void CourseConstructorTestListStudents()
        {
            string name = "Javascript";
            Student maria = new Student("Maria Petrova", 12345);
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.AddStudent(maria);
            Assert.IsTrue(course.Students.Contains(maria));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        public void AddStudentTestOneStudent()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Albena Stoeva", 12345);
            course.AddStudent(maria);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        public void AddStudentTestTwoStudents()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Albena Stoeva", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.AddStudent(maria);
            course.AddStudent(petar);
            Assert.IsTrue(course.Students.Count == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTestSameStudentTwoTimes()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Albena Stoeva", 12345);
            course.AddStudent(maria);
            course.AddStudent(maria);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentTestMoreThanMaximumStudents()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            for (int i = 0; i <= 30; i++)
            {
                course.AddStudent(new Student(("Student" + i), (1000 + i)));
            }
        }

        [TestMethod]
        public void RemoveStudentTest()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Albena Stoeva", 12345);
            Student petar = new Student("Dimitar Malinov", 23445);
            course.AddStudent(maria);
            course.AddStudent(petar);
            course.RemoveStudent(petar);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingStudentTest()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Albena Stoeva", 12345);
            course.RemoveStudent(maria);
        }
    }
}