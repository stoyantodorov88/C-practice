using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < lines; i++)
            {
                string wordKey = Console.ReadLine();
                string synonymValue = Console.ReadLine();
                if (!dict.ContainsKey(wordKey))
                {
                    dict.Add(wordKey, new List<string>());
                    dict[wordKey].Add(synonymValue);
                }
                else
                {
                    dict[wordKey].Add(synonymValue);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ", item.Value)}");
            }
        }
    }
}
