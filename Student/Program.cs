using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please, write your age: ");
            int age = Int32.Parse(Console.ReadLine());

            Student student = new Student(name, age);

            Console.WriteLine(student.Info);



           

        }
    }
}
