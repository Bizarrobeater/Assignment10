using System;

namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution10o1();
        }

        static void Solution10o0()
        {
            var student1 = new Student("Ben Solo");
            var student2 = new Student("Han Solo");

            Console.WriteLine($"{student1.Name} {student2.Name}");
        }

        static void Solution10o1()
        {
            var student1 = new Student("Ben Solo");
            var student2 = new Student("Han Solo");

            Console.WriteLine($"{student1.Name} {student2.Name}");

            student1.SetValue("Jacen Solo");
            student2.SetValue("Jaiden Solo");

            Console.WriteLine($"{student1.Name} {student2.Name}");
        }
    }
}
