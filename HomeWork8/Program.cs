using System;
using System.Collections.Generic;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack<Student> students = new Stack<Student>();

            students.Push(new Student() { Name = "Ivan" });
            Student studenttask1 = students.Peek();
            Console.WriteLine("Task from " + studenttask1.Name + " is received");

            students.Push(new Student() { Name = "Egor" });
            Student studenttask2 = students.Peek();
            Console.WriteLine("Task from " + studenttask2.Name + " is received");

            students.Push(new Student() { Name = "Dima" });

            Student studenttask3 = students.Peek();
            Console.WriteLine("Task from " + studenttask3.Name + " is received");





            Student student1 = students.Pop(); 
            Console.WriteLine(student1.Name + " got a cup of coffee");

            Student student2 = students.Pop();
            Console.WriteLine(student2.Name + " got a cup of coffee");

            Student student3 = students.Pop();
            Console.WriteLine(student3.Name + " got a cup of coffee");


            Console.ReadLine();


            Queue<StudentNew> studentsNew = new Queue<StudentNew>();
            studentsNew.Enqueue(new StudentNew() { Name = "Lera" });

            studentsNew.Enqueue(new StudentNew() { Name = "Alla" });

            studentsNew.Enqueue(new StudentNew() { Name = "Vika" });   

            foreach (StudentNew sn in studentsNew)
            {
                Console.WriteLine("Task from " + sn.Name + " is received");
            }




            
            StudentNew person1 = studentsNew.Dequeue(); 
            Console.WriteLine(person1.Name + " got a cup of coffee");

            StudentNew person2 = studentsNew.Dequeue();
            Console.WriteLine(person2.Name + " got a cup of coffee");

            StudentNew person3 = studentsNew.Dequeue();
            Console.WriteLine(person3.Name + " got a cup of coffee");

            Console.ReadLine();
        }
    }

    class Student
    {
        public string Name { get; set; }
    }

    class StudentNew
    {
        public string Name { get; set; }
    }
}
    

