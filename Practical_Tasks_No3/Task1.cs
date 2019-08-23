namespace Practical_Tasks_No3
{
    using System;
    using System.Collections.Generic;

    public class Task1
    {
        List<Person> people;

        Random rnd = new Random();

        public Task1() { }

        public void CreateRandomList()
        {
            people = new List<Person>()
            {
                GetNewRandomPerson(),
                GetNewRandomPerson(),
                GetNewRandomPerson(),
                GetNewRandomPerson(),
                GetNewRandomPerson(),
                GetNewRandomPerson(),
                GetNewRandomPerson()
            };
        }

        private Person GetNewRandomPerson()
        {
            return new Person
            {
                Age = GetRandomNumber(),
                Name = GetRandomName(),
                PhoneNumbers = new List<string> { GetRandomPhoneNumber(), GetRandomPhoneNumber() }
            };
        }

        private int GetRandomNumber()
        {
            return rnd.Next(18, 100);
        }

        private string GetRandomName()
        {
            string[] names = 
            {
                "Yaroslav", "Mykola", "Roman", "Andriy",
                "Nazar", "David", "Kolya", "Volodya",
                "Slavik", "Oleg", "Bogdan", "Misha"
            };

            return names[rnd.Next(names.Length)];
        }

        private string GetRandomPhoneNumber()
        {
            string number = "+38 (0";

            for (int i = 0; i < 10; i++)
            {
                number += i == 2 ? ") " : rnd.Next(0, 9).ToString();
            }
            return number;
        }

        public void DrawList()
        {
            if(people != null)
            {
                foreach (var person in people)
                {
                    Console.WriteLine($"Name: {person.Name} \t/ Age: {person.Age}");
                }
            }
            else
            {
                CreateRandomList();
            }
        }
    }
}
