namespace Practical_Tasks_No3
{
    using System;
    using System.Collections.Generic;

    public class Task2
    {
        List<Person> people;

        Random rnd = new Random();

        public Task2() { }

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

            for (int i = 0; i < 11; i++)
            {
                number += i == 6 ? " " : i == 2 ? ") " : rnd.Next(0, 9).ToString();
            }
            return number;
        }

        public void AddNewPeople(List<Person> people)
        {
            this.people.AddRange(people);
        }

        public void DrawList()
        {
            if(people != null)
            {
                foreach (var person in people)
                {
                    Console.Write($"Name: {person.Name} \t/ Age: {person.Age} / Number: ");

                    foreach (var number in person.PhoneNumbers)
                    {
                        Console.Write($"{number}\t");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                CreateRandomList();
            }
        }
    }
}