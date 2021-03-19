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


            Queue<Student> studentsNew = new Queue<Student>();
            studentsNew.Enqueue(new Student() { Name = "Lera" });

            studentsNew.Enqueue(new Student() { Name = "Alla" });

            studentsNew.Enqueue(new Student() { Name = "Vika" });   

            foreach (Student sn in studentsNew)
            {
                Console.WriteLine("Task from " + sn.Name + " is received");
            }




            
            Student person1 = studentsNew.Dequeue(); 
            Console.WriteLine(person1.Name + " got a cup of coffee");

            Student person2 = studentsNew.Dequeue();
            Console.WriteLine(person2.Name + " got a cup of coffee");

            Student person3 = studentsNew.Dequeue();
            Console.WriteLine(person3.Name + " got a cup of coffee");

            Console.ReadLine();
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
        
}
    

