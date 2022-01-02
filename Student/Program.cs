using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please, write your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please, write your age: ");
            int age = Int32.Parse(Console.ReadLine());

            Student student = new Student(name, age);

            Console.WriteLine(student.Info);*/
            Bonus();
        }

        static void Bonus()
        {
            Console.WriteLine("Enter the number of students: ");
            int length = Int32.Parse(Console.ReadLine());
            Student[] students = new Student[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please, write full name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Please, write age: ");
                int age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please, write mark: ");
                int mark = Int32.Parse(Console.ReadLine());

                students[i] = new Student(name, age);
                students[i].Mark = mark;
            }

            int sum = 0;

            foreach (var student in students)
            {
                if (student.Mark.HasValue)
                    sum += student.Mark.Value;
            }

            Console.WriteLine($"The average mark is: {sum / length}");

        }
    }
}
