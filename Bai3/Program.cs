using System;

namespace ExercisesLesson43
{
    class Exercises3
    {
        static void Main()
        {
            
        }

        static void ShowInfo(string first, string last, string mid)
        {
            Console.WriteLine("First name: " + first);
            Console.WriteLine("Last name: " + last);
            Console.WriteLine("Middle name: " + mid);
        }

        static void ShowInfo(string first, string last, string mid, int age)
        {
            ShowInfo(first, last, mid);
            Console.WriteLine("Age: " + age);
        }

        static void ShowInfo(string first, string last,
            string mid, int age, string address)
        {
            ShowInfo(first, last, mid, age);
            Console.WriteLine("Address: " + address);
        }

        static void ShowInfo(string first, string last,
            string mid, int age, string address, float gpa)
        {
            ShowInfo(first, last, mid, age, address);
            Console.WriteLine("Gpa: " + gpa);
        }
    }
}