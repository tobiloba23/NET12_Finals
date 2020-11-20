using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]{
                new Adult(),
                new Child()
            };

            foreach (Person person in people)
            {
                Console.WriteLine($"First Name: {person.FirstName}, Last Name: {person.LastName}");
            }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class Adult : Person
        {
            public Adult() {
                FirstName = "AdultFirstName";
                LastName = "AdultLastName";
            }
        }

        public class Child : Person
        {
            public Child()
            {
                FirstName = "ChildFirstName";
                LastName = "ChildLastName";
            }
        }
    }
}
