using System;
using System.Collections.Generic;
namespace PersonTaskAbstract
{
    class StudentList
    {
        List<Student> list;

        public StudentList()
        {
            list = new List<Student>();
        }

        public bool AddStudent(Student student)
        {
            foreach(Student st in list)
            {
                if(st.Equals(student))
                {
                    return false;
                }
            }
            list.Add(student);
            return true;
        }
        public string FindStudentByFamily(string lastName)
        {
            string result = "";
            foreach(Student st in list)
            {
                if (st.LastName.Equals(lastName))
                {
                    result += st.ToString()+ "\n";
                }
            }
            return result;
        }

        public void Print()
        {
            foreach(Student st in list)
            {
                Console.WriteLine(st);
            }
        }


    }
}