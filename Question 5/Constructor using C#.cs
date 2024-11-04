using System;

namespace ConstructorExample
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "Unknown";
            age = 0;
            Console.WriteLine("Default Constructor Called");
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Parameterized Constructor Called");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.DisplayInfo();

            Person person2 = new Person("Tomba", 20);
            person2.DisplayInfo();
        }
    }
}
