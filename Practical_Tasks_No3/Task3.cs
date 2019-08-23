namespace Practical_Tasks_No3
{
    using System;
    using System.Collections.Generic;

    public class Task3
    {
        private Random random;

        public Task3()
        {
            random = new Random();
        }

        public List<string> GetRandomListGeneration()
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < random.Next(100, 999); i++)
            {
                strings.Add(GetRandomStringGeneration());
            }

            return strings;
        }

        private string GetRandomStringGeneration()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[4];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        public List<string> DeleteRepetitionsInTheList(List<string> strings)
        {
            return new List<string>(new HashSet<string>(strings));
        }

        public List<string> DeleteRowsThatBeginOnZ(List<string> strings)
        {
            List<string> stringsToRemove = new List<string>();

            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i].StartsWith("Z"))
                {
                    strings.RemoveAt(i);
                    i--;
                }
            }

            return strings;
        }

        public List<string> SortList(List<string> strings)
        {
            strings.Sort();
            strings.Reverse();

            return strings;
        }

        public void DisplayPage(int pageNumber, List<string> strings)
        {
            const int countElements = 5;
            int currentIndex = 0;
            for (int i = 0; i < countElements; i++)
            {
                currentIndex = pageNumber * countElements + i;
                if (strings.Count <= currentIndex)
                {
                    Console.WriteLine($"List have only {strings.Count / countElements} pages");
                    break;
                }
                Console.WriteLine($"[#{currentIndex + 1}]\t{strings[currentIndex]}");
            }
        }

        public void DisplayAllList(List<string> strings)
        {
            foreach (var s in strings)
            {
                Console.WriteLine($"[#{strings.IndexOf(s) + 1}]\t{s}");
            }
        }
    }
}
