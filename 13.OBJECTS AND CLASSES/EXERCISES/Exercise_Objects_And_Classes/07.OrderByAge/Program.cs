
namespace _07.OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input  == "End")
                {
                    break;
                }

                string[] personData = input.Split().ToArray();

                string name = personData[0];
                string id = personData[1];
                int age = int.Parse(personData[2]);

                Person currentPerson = new Person()
                {
                    Name = name,
                    ID = id,
                    Age = age
                };

                people.Add(currentPerson);
            }

            foreach (var person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
   
    }
}
