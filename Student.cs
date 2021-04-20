using System;
namespace PersonTaskAbstract
{
    class Student :Person
    {
        string facultet;
        int course;

        public string Facultet
        {
           get { return facultet; }
        }

        public int Course
        {
            get { return course; }
        }

        public Student(string firstName, string lastName, string idNumber, string facultet, int course ) :base(firstName, lastName, idNumber)
        {
            this.course = course;
            this.facultet = facultet;
        }


        public override string ToString()
        {
            return base.ToString() + String.Format("Facultet: {0} Course: {1}", facultet, course);
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   base.Equals(obj) &&
                   Facultet == student.Facultet &&
                   Course == student.Course;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Facultet, Course);
        }
    }
}
