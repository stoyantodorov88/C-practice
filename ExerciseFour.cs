using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Excersize
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();
                }
                dict[name].Add(grade);

            }

            dict = dict
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine(String.Join(Environment.NewLine, dict.Select(x => $"{x.Key} -> {x.Value.Average():f2}")));
        }
    }
}
