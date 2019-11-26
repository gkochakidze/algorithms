// https://codeforces.com/problemset/problem/987/A
using System;
using System.Collections.Generic;

namespace algorithms_700_01
{
    public class InfinityGauntlet
    {
        public void Solve()
        {
            var dictionary = new Dictionary<string, string>
            {
                { "purple", "Power" },
                { "green", "Time" },
                { "blue", "Space" },
                { "orange", "Soul" },
                { "red", "Reality" },
                { "yellow", "Mind" },
            };
            var stonesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < stonesCount; i++)
                dictionary.Remove(Console.ReadLine());
            Console.WriteLine(dictionary.Count);
            foreach (var pair in dictionary)
                Console.WriteLine(pair.Value);
        }
    }
}
