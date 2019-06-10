
namespace _02.OldestFamilyMember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
   
        public string Name { get; set; }

        public int Age { get; set; }

    }

    public class Family
    {
        public Family()
        {
            Members = new List<Person>();

        }
        public List<Person> Members { get; set; }

        public void AddMember(Person person)
        {
            Members.Add(person);
        }

        public Person GetOldestMember()
        {
             
            return Members.OrderByDescending(m => m.Age).First();
        }
    }


    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());

            Family familyMembers = new Family();

            for (int i = 0; i < limit; i++)
            {
                string[] personData = Console.ReadLine().Split().ToArray();

                string personName = personData[0];
                int age = int.Parse(personData[1]);

                Person currentPerson = new Person()
                {
                    Name = personName,
                    Age =  age              
                };

               familyMembers.AddMember(currentPerson);
            }

            Person oldestMember = familyMembers.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
