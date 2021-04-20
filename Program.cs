using System;

namespace PersonTaskAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Alex", "Grigorjev", "123123", "WEB", 1);
            Student st2 = new Student("Alex", "Grigorjev", "123123", "WEB", 1);
            Student st3 = new Student("Alex", "Ivanov", "123123", "WEB", 1);
            Student st4 = new Student("Ivan", "Ivanov", "345", "Tech", 2);
            Console.WriteLine(st1);
            
            StudentList list = new StudentList();
            Console.WriteLine(list.AddStudent(st1));
            Console.WriteLine(list.AddStudent(st2));
            Console.WriteLine(list.AddStudent(st3));
            Console.WriteLine(list.AddStudent(st4));
            string temp = list.FindStudentByFamily("Ivanov");
            if(temp == "")
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(temp);
            }
            list.Print();
        }
    }
}
